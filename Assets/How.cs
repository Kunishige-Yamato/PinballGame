using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class How : MonoBehaviour
{
    public int timer;

    void Start()
    {
        timer=0;
    }

    void Update()
    {
        timer++;

        if(timer>500&&Input.anyKeyDown){
            SceneManager.LoadScene("Title");
        }
        
    }
}
