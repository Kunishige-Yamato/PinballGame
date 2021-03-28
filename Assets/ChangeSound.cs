using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    public Slider slider;
    public GameObject MainMusic;
    MainSound mainSound;

    void Start()
    {
        slider=GetComponent<Slider>();

        MainMusic=GameObject.Find("MainMusic");
        mainSound=MainMusic.GetComponent<MainSound>();

        slider.value=PlayerPrefs.GetInt("BGM");
    }

    void Update()
    {
        PlayerPrefs.SetInt("BGM",(int)slider.value);
        PlayerPrefs.Save();
        mainSound.mode=(int)slider.value;
    }
}
