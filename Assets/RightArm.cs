using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArm : MonoBehaviour
{
    public Rigidbody rigid;
    public int push;
    public int pushTimer;
    public Quaternion rotDef;
    public GameObject MainCamera;
    Main Main;

    void Start()
    {
        push=0;
        pushTimer=0;
        rotDef=transform.rotation;
        MainCamera=GameObject.Find("Main Camera");
        Main=MainCamera.GetComponent<Main>();
    }

    void Update()
    {
        if(Main.gameMode==1){

            if(Input.anyKeyDown&&push==0){
                transform.rotation=rotDef;
                push=1;
            }

            if(push==1&&pushTimer<12){
                Quaternion rot = Quaternion.AngleAxis(-5, Vector3.forward);
                Quaternion q = this.transform.rotation;
                this.transform.rotation = q * rot;
                pushTimer++;
            }
            else if(push==1&&pushTimer<24){
                Quaternion rot = Quaternion.AngleAxis(5, Vector3.forward);
                Quaternion q = this.transform.rotation;
                this.transform.rotation = q * rot;
                pushTimer++;
            }
            else{
                pushTimer=0;
                push=0;
            }
        }
            
    }
}
