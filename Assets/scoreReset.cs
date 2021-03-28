using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreReset : MonoBehaviour
{
    public GameObject ConfirButton;
    public GameObject CancelButton;
    public int highScore;
    public Text highText;

    void Start()
    {
        ConfirButton.SetActive(false);
        CancelButton.SetActive(false);
        highScore=PlayerPrefs.GetInt("HIGH");
        highText.text=("High Score: "+highScore+" points");
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        highText.text=("Is it really good?");
        ConfirButton.SetActive(true);
        CancelButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
