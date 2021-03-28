using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tama : MonoBehaviour
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
        if(Main.gameMode==1){
            if(this.transform.position.y<-5){
                Main.BallCount--;
                Destroy(this.gameObject);
            }
        }
        if(Main.gameMode==2){
            Destroy(this.gameObject);
        }
    }
}
