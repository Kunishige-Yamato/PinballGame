using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : MonoBehaviour
{
    public GameObject windmill;
    public Rigidbody rigid;
    public int rotationSpeed;
    public Vector3 size;

    void Start()
    {
        rigid=GetComponent<Rigidbody>();
        while(rotationSpeed==0){
            rotationSpeed=Random.Range(-10,10);
        }
        size=new Vector3(Random.Range(1,3),(float)0.2,1);
        windmill.transform.localScale=size;
    }

    void Update()
    {
        rigid.angularVelocity=new Vector3(0, 0,rotationSpeed);
    }
}
