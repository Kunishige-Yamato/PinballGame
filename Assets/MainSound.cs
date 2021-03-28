using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    public int music;
    public int mode;
    public GameObject Cyber;
    public GameObject Neorock;
    public GameObject Healing;

    void Start()
    {
        music=FindObjectsOfType<MainSound>().Length;
        
        if(mode!=2&&mode!=3){
            PlayerPrefs.SetInt("BGM",1);
        }
        mode=PlayerPrefs.GetInt("BGM");

        if(music>1){
            Destroy(gameObject);
        }
        else{
            DontDestroyOnLoad(this);
        }
    }

    void Update()
    {
        if(mode==1){
            Cyber.SetActive(true);
            Neorock.SetActive(false);
            Healing.SetActive(false);
        }
        if(mode==2){
            Cyber.SetActive(false);
            Neorock.SetActive(true);
            Healing.SetActive(false);
        }
        if(mode==3){
            Cyber.SetActive(false);
            Neorock.SetActive(false);
            Healing.SetActive(true);
        }
    }
}
