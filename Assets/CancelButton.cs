using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    public GameObject resetButton;
    public GameObject ConfirButton;
    public int highScore;
    public Text highText;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        highScore=PlayerPrefs.GetInt("HIGH");
        highText.text=("High Score: "+highScore+" points");
        ConfirButton.SetActive(false);
        resetButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
