using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTama : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(this.transform.position.y<-10||this.transform.position.x<-7||this.transform.position.x>7){
            Destroy(this.gameObject);
        }
    }
}
