using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst : MonoBehaviour
{
    public GameObject Enmy1, Enmy2, Enmy3, Enmy4,
                      Enmy1Parent, Enmy2Parent, Enmy3Parent,Enmy4Parent;

    Vector3 Enmy1Pos, Enmy2Pos, Enmy3Pos, Enmy4Pos;

    public float _Time;
    // Start is called before the first frame update
    void Start()
    {
        _Time = Time.time + 1f;

        Enmy1Pos = Enmy1Parent.transform.position;
        Enmy2Pos = Enmy2Parent.transform.position;
        Enmy3Pos = Enmy3Parent.transform.position;
        Enmy4Pos = Enmy4Parent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _Time)
        {
            Instantiate(Enmy1, Enmy1Pos, Quaternion.identity);
            Instantiate(Enmy2, Enmy2Pos, Quaternion.identity);
            Instantiate(Enmy3, Enmy3Pos, Quaternion.identity);
            Instantiate(Enmy4, Enmy4Pos, Quaternion.identity);

            _Time += 1f;
        }
    }
}
