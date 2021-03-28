using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject ObstacleMain;

    public GameObject KugiPrefab;
    public int KugiCount;
    int KugiCountMax;

    public GameObject WindmillPrefab;
    public int WindmillCount;
    int WindmillCountMax;

    public GameObject BallPrefab;
    public int BallCount;
    
    public int gameTimer;

    public int ball_color;
    public int bg_color;
    
    public Texture ballTexture_1;
    public Texture ballTexture_2;
    public Texture ballTexture_3;
    public Texture ballTexture_4;
    public Texture ballTexture_5;
    public Texture ballTexture_6;
    public Texture bgTexture_1;
    public Texture bgTexture_2;
    public Texture bgTexture_3;
    public Texture bgTexture_4;
    public Texture bgTexture_5;
    public Texture bgTexture_6;
    
    public Material ballMaterial;
    public Material bgMaterial;

    void Start()
    { 
        KugiCount=0;
        KugiCountMax=100;

        WindmillCount=0;
        WindmillCountMax=2;

        BallCount=0;
        
        gameTimer=0;

        ball_color=PlayerPrefs.GetInt("BALLCOLOR");
        bg_color=PlayerPrefs.GetInt("BGCOLOR");
        switch(ball_color){
            case 1:
                ballMaterial.SetTexture("_MainTex",ballTexture_1);
                break;
            case 2:
                ballMaterial.SetTexture("_MainTex",ballTexture_2);
                break;
            case 3:
                ballMaterial.SetTexture("_MainTex",ballTexture_3);
                break;
            case 4:
                ballMaterial.SetTexture("_MainTex",ballTexture_4);
                break;
            case 5:
                ballMaterial.SetTexture("_MainTex",ballTexture_5);
                break;
            case 6:
                ballMaterial.SetTexture("_MainTex",ballTexture_6);
                break;
            default:
                ballMaterial.SetTexture("_MainTex",ballTexture_1);
                PlayerPrefs.SetInt("BALLCOLOR",1);
                PlayerPrefs.SetInt("BGCOLOR",1);
                break;
        }
        switch(bg_color){
            case 1:
                bgMaterial.SetTexture("_MainTex",bgTexture_1);
                break;
            case 2:
                bgMaterial.SetTexture("_MainTex",bgTexture_2);
                break;
            case 3:
                bgMaterial.SetTexture("_MainTex",bgTexture_3);
                break;
            case 4:
                bgMaterial.SetTexture("_MainTex",bgTexture_4);
                break;
            case 5:
                bgMaterial.SetTexture("_MainTex",bgTexture_5);
                break;
            case 6:
                bgMaterial.SetTexture("_MainTex",bgTexture_6);
                break;
            default:
                bgMaterial.SetTexture("_MainTex",bgTexture_1);
                break;
        }
    }

    void Update()
    {

        //釘配置
        if(KugiCount < KugiCountMax)
        {
            GameObject Kugi = GameObject.Instantiate(KugiPrefab);
            Vector3 PosTemp = ObstacleMain.transform.position;
            var ran=(float)Random.Range(0,15);
            ran=(float)ran/(float)1.5;
            PosTemp.x+=ran;
            ran=(float)Random.Range(5,30);
            ran=(float)ran/(float)1.5;
            PosTemp.y+=(ran+(float)0.5);
            Kugi.transform.position=PosTemp;
            KugiCount++;
        }
        
        //回転板配置
        if(WindmillCount < WindmillCountMax)
        {
            GameObject Windmill = GameObject.Instantiate(WindmillPrefab);
            Vector3 PosTemp = ObstacleMain.transform.position;
            PosTemp.x+=Random.Range((float)2,(float)8);
            PosTemp.y+=Random.Range((float)2,(float)20);
            Windmill.transform.position=PosTemp;
            WindmillCount++;
        }

        //初期玉配置
        if(gameTimer%10==0){
            AddBall();
        }

        gameTimer++;
    }

    public void AddBall()
    {
        GameObject Ball = GameObject.Instantiate(BallPrefab);
        Vector3 PosTemp = BallPrefab.transform.position;
        PosTemp.x+=Random.Range((float)-5,(float)4);
        PosTemp.z=6;
        Ball.transform.position=PosTemp;
    }
}
