using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed, MouseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        MouseSpeed =2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(-Vector3.up * MouseSpeed);
        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up * MouseSpeed);
    }
}
