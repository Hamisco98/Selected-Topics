using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    GameObject target;
    Vector3 targetPostion, sourcePostion;
    [SerializeField]
    private Vector3 velocity;
    public float speed;
    public float Distance;

    private void Start()
    {
        speed = 5f;
        target = GameObject.FindGameObjectWithTag("mPlayer");
    }
    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("mPlayer");


        Distance = target.transform.position.z - gameObject.transform.position.z;

        targetPostion = target.transform.position;
        sourcePostion = gameObject.transform.position;
        velocity = (targetPostion - sourcePostion).normalized * speed * Time.deltaTime;
        gameObject.transform.position += new Vector3() + velocity;
        

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("here");
        if (col.gameObject.name == "AtomBall")
        {
            Destroy(gameObject);
        }
        
    }
}
