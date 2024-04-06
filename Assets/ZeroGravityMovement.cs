using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;
public class ZeroGravityMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float rotationSpeed = 2f; // Rotation speed
    public Quaternion forward;
    public AudioSource swoosh;
    public Camera camera;
    private Rigidbody rb;
    public float arrowLength = 2.5f;
    private Vector3 prevVel;
    public VisualEffect rocketLeft;
    public VisualEffect rocketRight;
    public float SpeedBoost;
    public float AngleLimit;
    public float AngleMaxLimit;
    public float precisionMultiplier;
    public float initialFOV = 60f; // Initial FOV value of the camera
    public float precisionFOV = 30f; // FOV value when precision mode is activated
    public float fovChangeSpeed = 1f; // Speed at which FOV changes
    public float cameraFollowSpeedOffset = 50;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        // Get input for translation (movement) along X, Y, and Z axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveForward = Input.GetAxis("Depth");

        // Calculate movement vector based on input
        Vector3 movement = new Vector3(-moveHorizontal, moveForward, -moveVertical);

        // Normalize the movement vector to maintain consistent speed regardless of direction
        if (movement.magnitude > 1f)
        {
            movement.Normalize();
            if(movement.magnitude > 1f)
            {
                rocketLeft.SetFloat("flame length", .25f);
            }
            else
            {
                rocketLeft.SetFloat("flame length", .15f);
            }
        }

        if(movement.sqrMagnitude==0 && Input.GetKey(KeyCode.Q))
        {
            rb.drag = 5;
        }
        else
        {
            rb.drag = 0;
        }
        float ms = moveSpeed;
        // Apply translation (movement) to the rigidbody
        Vector3 absMov = rb.rotation * movement;
        float DiffAngle=Mathf.Acos(Vector3.Dot(rb.velocity.normalized,absMov.normalized))*Mathf.Rad2Deg;
        if(DiffAngle<AngleLimit || DiffAngle>AngleMaxLimit) moveSpeed *= SpeedBoost;

        rb.AddRelativeForce(forward*(movement * moveSpeed));

        // Get input for rotation around the X and Y axes
        float rotateX = Input.GetAxis("Pitch");
        float rotateY = Input.GetAxis("Yaw");
        float rotateZ = Input.GetAxis("Roll");
        if (Input.GetKey(KeyCode.LeftControl))
        {
            // Apply precision mode to rotation
            rotateX *= precisionMultiplier;
            rotateY *= precisionMultiplier;
            rotateZ *= precisionMultiplier;

            // Reduce FOV gradually
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, precisionFOV, Time.deltaTime * fovChangeSpeed);
        }
        else
        {
            // Restore normal FOV gradually
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, initialFOV, Time.deltaTime * fovChangeSpeed);
        }

        // Calculate rotation vector based on input
        Vector3 rotation = new Vector3(rotateX, rotateY, 0f);

        
        transform.RotateAroundLocal(transform.up, -rotateY);
        transform.RotateAroundLocal(transform.right, rotateX);
        transform.RotateAroundLocal(transform.forward, rotateZ);
        //rb.AddRelativeTorque(rotation * rotationSpeed);
        swoosh.volume=ApproachOne(rb.velocity.magnitude);
        prevVel = rb.velocity;
        camera.GetComponent<CameraFollow>().followSpeed = rb.velocity.magnitude+cameraFollowSpeedOffset;

    }
    void OnDrawGizmos()
    {
    }
    public float ApproachOne(float value)
    {
        if (value <= 0)
        {
            return 0f;
        }
        else
        {
            return 1f - (1f / (1f + value));
        }
    }

}
