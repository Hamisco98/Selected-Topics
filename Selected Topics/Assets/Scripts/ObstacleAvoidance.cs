using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoidance : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    public float speed;
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);


        if (Physics.Raycast(ray, out hit, 4f))
        {
            if (hit.collider.tag == "Player")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                Debug.Log("Did Hit");

                //transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * speed);
                transform.Rotate(0, -10 * Time.deltaTime, 0);
            }
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.white);
            Debug.Log("Did not Hit");

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
