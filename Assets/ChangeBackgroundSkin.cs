using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackgroundSkin : MonoBehaviour
{
    public Texture bgTexture;
    public Texture bgTextureDef;
    public Material bgMaterial;
    public int coin;
    public int BG_num;
    public int needCoin;
    Image btnImage;

    void Start()
    {
        bgMaterial.SetTexture("_MainTex",bgTextureDef);
        PlayerPrefs.SetInt("BGCOLOR",1);
        coin=PlayerPrefs.GetInt("MONEY");
        btnImage = this.GetComponent<Image>();
        if(coin>=needCoin){
            btnImage.color=Color.white;
            Debug.Log(gameObject.name+":white");
        }
        else{
            btnImage.color=Color.black;
            Debug.Log(gameObject.name+":black");
        }
    }

    void Update()
    {
        
    }
    
    public void OnClick(){
        if(coin>=needCoin){
            bgMaterial.SetTexture("_MainTex",bgTexture);
            PlayerPrefs.SetInt("BGCOLOR",BG_num);
        }
    }
}
