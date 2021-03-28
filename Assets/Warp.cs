using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public GameObject MainCamera;
    Main Main;

    void Start()
    {
        MainCamera=GameObject.Find("Main Camera");
        Main=MainCamera.GetComponent<Main>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Sphere(Clone)"){
            Destroy(col.gameObject);
            Main.BallCount--;
            Main.AddBall();
        }
    }
}
