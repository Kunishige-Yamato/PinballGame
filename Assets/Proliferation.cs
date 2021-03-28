using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proliferation : MonoBehaviour
{
    public GameObject ObstacleMain;
    public GameObject MainCamera;
    Main Main;
    public Vector3 size;

    void Start()
    {
        size=new Vector3(2,1,2);
        this.transform.localScale=size;
        MainCamera=GameObject.Find("Main Camera");
        ObstacleMain=GameObject.Find("Obstacle");
        Main=MainCamera.GetComponent<Main>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Sphere(Clone)"){
            size.x*=(float)0.9;
            size.z*=(float)0.9;
            Main.gameTimer=Main.gameTimerDef;
            if(size.x>0.8){
                this.transform.localScale=size;

                Vector3 PosTemp = ObstacleMain.transform.position;
                PosTemp.x+=Random.Range((float)2,(float)8);
                PosTemp.y+=Random.Range((float)3,(float)5);
                this.transform.position=PosTemp;
            }
            else{
		        Destroy(this.gameObject);
                for(int i=0;i<50;i++){
                    Main.AddBall();
                    Debug.Log("JuckPot!!!!!!!!!");
                }
            }
            Main.AddBall();
        }
    }
}
