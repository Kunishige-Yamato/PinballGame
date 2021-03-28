using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mato : MonoBehaviour
{
    public GameObject ObstacleMain;
    public GameObject MainCamera;
    Main Main;

    void Start()
    {
        MainCamera=GameObject.Find("Main Camera");
        ObstacleMain=GameObject.Find("Obstacle");
        Main=MainCamera.GetComponent<Main>();

        Vector3 PosTemp = ObstacleMain.transform.position;
        PosTemp.x+=Random.Range((float)0,(float)10);
        PosTemp.y+=Random.Range((float)3,(float)5);
        this.transform.position=PosTemp;
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Sphere(Clone)"){
            Main.gameTimer=Main.gameTimerDef;
            Main.Score+=10;
            Vector3 PosTemp = ObstacleMain.transform.position;
            PosTemp.x+=Random.Range((float)0,(float)10);
            PosTemp.y+=Random.Range((float)3,(float)10);
            this.transform.position=PosTemp;
        }
    }
}
