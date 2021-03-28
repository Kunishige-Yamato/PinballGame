using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBallSkin : MonoBehaviour
{
    public Texture ballTexture;
    public Texture ballTextureDef;
    public Material ballMaterial;
    public int BALL_num;
    public int coin;
    public int needCoin;
    Image btnImage;

    void Start()
    {
        ballMaterial.SetTexture("_MainTex",ballTextureDef);
        PlayerPrefs.SetInt("BALLCOLOR",1);
        coin=PlayerPrefs.GetInt("MONEY");
        btnImage = this.GetComponent<Image>();
        if(coin>=needCoin){
            btnImage.color=Color.white;
        }else{
            btnImage.color=Color.black;
        }
    }

    void Update()
    {
        
    }

    public void OnClick(){
        if(coin>=needCoin){
            ballMaterial.SetTexture("_MainTex",ballTexture);
            PlayerPrefs.SetInt("BALLCOLOR",BALL_num);
        }
    }
}
