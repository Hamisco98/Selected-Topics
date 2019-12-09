using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FollowPath : MonoBehaviour
{
    public Transform[] Paths;

    public float speed;

    int currentPath;

    void Start()
    {
        speed = 5f;
        currentPath = 0;
    }

    void Update()
    {
        if (currentPath < Paths.Length)
        {
            if (transform.position != Paths[currentPath].position)
            {
                Debug.Log("is not equal");
                transform.localRotation = Paths[currentPath].rotation;
                transform.position = Vector3.MoveTowards(transform.position, Paths[currentPath].position, speed * Time.deltaTime);

            }
            else
            {
                currentPath++;
                Debug.Log("is equal");
            }
        }

        
    }
}
