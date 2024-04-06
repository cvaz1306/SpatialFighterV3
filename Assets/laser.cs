using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public Transform Laser;
    RaycastHit hit;
    public float speed;
    float age;
    public float maxAge;
    public float minAge;
    public Vector3 initialVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (age > maxAge)
        {
            Debug.Log("Destroying");
            Destroy(gameObject);
        }
        age += speed;
        transform.position += transform.forward * Time.deltaTime*speed;
        //transform.position += initialVelocity;
        if(Laser != null &&age>minAge)
        {
            if(Physics.Raycast(new Ray(Laser.position, Laser.forward), out hit, 5)){
                Destroy(gameObject);
                Destroy(hit.collider.gameObject);
                Debug.Log("Destroying Raycasting");
            }
        }
    }
}
