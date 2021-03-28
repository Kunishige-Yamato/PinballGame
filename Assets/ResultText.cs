using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultText : MonoBehaviour
{
    public int highScore;
    public int result;
    public Text resultText;
    public Text highText;
    public int timer;
    public int coin;

    void Start()
    {
        timer=0;
        highScore=PlayerPrefs.GetInt("HIGH");
        result=Main.Score;
        resultText.text=("Score: "+result+" points");

        coin=PlayerPrefs.GetInt("MONEY");
        coin+=result;
        PlayerPrefs.SetInt("MONEY",coin);
        PlayerPrefs.Save();

        if(result>=highScore){
            highScore=result;
            PlayerPrefs.SetInt("HIGH",highScore);
            PlayerPrefs.Save();
        }
        highText.text=("High Score: "+highScore+" points");
    }

    void Update()
    {
        if(Input.anyKeyDown&&timer>50){
            SceneManager.LoadScene("Title");
        }

        timer++;
    }
}
