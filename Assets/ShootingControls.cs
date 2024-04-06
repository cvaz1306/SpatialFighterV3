using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingControls : MonoBehaviour
{
    public Transform leftGun;
    public Transform rightGun;

    public Transform leftGunPlacholder;
    public Transform rightGunPlacholder;

    public GameObject laserPrefab;
    public int countdown;
    public int countdownDefault = 10;
    Vector3 targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        countdown = countdownDefault;
        leftGunPlacholder.rotation=leftGun.rotation;
        rightGunPlacholder.rotation = rightGun.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool setcdown = false;
        countdown--;
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit hit;
        bool h = Physics.Raycast(ray, out hit);
        if (h)
        {
            
            leftGun.LookAt(hit.point);
            rightGun.LookAt(hit.point);
            targetPoint = hit.point;
            setcdown = true;
        }
        else
        {
            // If the ray doesn't hit anything, print a message
            
            leftGun.rotation = leftGunPlacholder.rotation;
            rightGun.rotation = leftGunPlacholder.rotation;
            targetPoint = Camera.main.transform.position;
        }
        if (countdown < 1 || h)
        {
            countdown = countdownDefault;
            if (Input.GetMouseButton(0))
            {
                GameObject i = Instantiate(laserPrefab, leftGun.position, leftGun.rotation);
                i.GetComponent<laser>().initialVelocity=GetComponent<Rigidbody>().velocity * Time.deltaTime;
                GameObject j = Instantiate(laserPrefab, rightGun.position, rightGun.rotation);
                j.GetComponent<laser>().initialVelocity = GetComponent<Rigidbody>().velocity * Time.deltaTime;
                i.GetComponent<laser>().maxAge = 5000000;
                j.GetComponent<laser>().maxAge = 5000000;

                Debug.Log("Firing");
            }
        }


        // Perform a raycast from the center of the screen


        // Check if the ray hits an object


    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(leftGun.transform.position, leftGun.transform.position + leftGun.transform.forward);
        Gizmos.DrawLine(rightGun.transform.position, rightGun.transform.position + rightGun.transform.forward);
        Gizmos.color= Color.green;
        Gizmos.DrawLine(Camera.main.transform.position, targetPoint);

    }
}
