using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour
{
     GameObject target;
    Vector3 targetPostion, sourcePostion;
    [SerializeField]
    private Vector3 velocity;
    public float speed;

    private void Start()
    {
        speed = 0.1f;
        target = GameObject.Find("AtomBall");
    }
    private void Update()
    {
        target = GameObject.Find("AtomBall");

        targetPostion = target.transform.position;
        sourcePostion = gameObject.transform.position;
        FleE();
        gameObject.transform.position += new Vector3() + velocity;

    }

    public void FleE()
    {
        velocity = (sourcePostion - targetPostion).normalized * speed;
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
