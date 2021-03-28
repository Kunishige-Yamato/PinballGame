using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mato2 : MonoBehaviour
{
    public GameObject ObstacleMain;
    public GameObject MainCamera;
    Main Main;
    public int mode;

    void Start()
    {
        MainCamera=GameObject.Find("Main Camera");
        ObstacleMain=GameObject.Find("Obstacle");
        Main=MainCamera.GetComponent<Main>();
        mode=0;
    }

    void Update()
    {
        Vector3 pos=this.transform.position;

        if(mode==0&&this.transform.position.y<20){
            pos.y+=0.1f;
        }
        else{
            mode=1;
        }
        if(mode==1&&this.transform.position.y>8){
            pos.y-=0.1f;
        }
        else{
            mode=0;
        }

        this.transform.position=pos;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="Sphere(Clone)"){
            Main.Score+=1;
        }
    }
}
