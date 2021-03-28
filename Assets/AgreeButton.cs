using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgreeButton : MonoBehaviour
{
    public GameObject resetButton;
    public GameObject CancelButton;
    public Text highText;
    public Text coinText;
    public Texture bgTextureDef;
    public Material bgMaterial;
    public Texture ballTextureDef;
    public Material ballMaterial;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        ballMaterial.SetTexture("_MainTex",ballTextureDef);
        bgMaterial.SetTexture("_MainTex",bgTextureDef);
        PlayerPrefs.SetInt("MONEY",0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("HIGH",0);
        PlayerPrefs.Save();
        highText.text=("High Score: 0 points");
        coinText.text=("0");
        CancelButton.SetActive(false);
        resetButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
