using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
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

    public GameObject ProliferationPrefab;
    public int ProliferationCount;
    int ProliferationCountMax;

    public GameObject Mato1Prefab;
    public int Mato1Count;
    int Mato1CountMax;

    public GameObject Mato2Prefab;
    public int Mato2Count;
    int Mato2CountMax;

    public GameObject WarpPrefab;
    public int WarpCount;
    int WarpCountMax;
    int warpPos=0;

    public int gameMode;
    public static int Score;
    public int gameTimer;
    public int gameTimerDef;
    public Text scoreText;
    public Slider sli;

    void Start()
    {    
        KugiCount=0;
        KugiCountMax=50;

        WindmillCount=0;
        WindmillCountMax=Random.Range(1,3);

        BallCount=0;

        ProliferationCount=0;
        ProliferationCountMax=1;

        Mato1Count=0;
        Mato1CountMax=3;

        Mato2Count=0;
        Mato2CountMax=1;

        WarpCount=0;
        WarpCountMax=2;

        gameMode=0;
        Score=0;
        gameTimerDef=200;
        gameTimer=gameTimerDef;

        sli.maxValue=gameTimerDef;
        sli.value=gameTimer;
    }

    void Update()
    {
        if(gameMode==0){

            //釘配置
            if(KugiCount < KugiCountMax)
            {
                GameObject Kugi = GameObject.Instantiate(KugiPrefab);
                Vector3 PosTemp = ObstacleMain.transform.position;
                var ran=(float)Random.Range(0,15);
                ran=(float)ran/(float)1.5;
                PosTemp.x+=ran;
                ran=(float)Random.Range(5,21);
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
                PosTemp.y+=Random.Range((float)3,(float)10);
                Windmill.transform.position=PosTemp;
                WindmillCount++;
            }

            //ジャックポット配置
            if(ProliferationCount < ProliferationCountMax)
            {
                GameObject Proliferation = GameObject.Instantiate(ProliferationPrefab);
                Vector3 PosTemp = ObstacleMain.transform.position;
                PosTemp.x+=Random.Range((float)3,(float)7);
                PosTemp.y+=Random.Range(3,5);
                Proliferation.transform.position=PosTemp;
                ProliferationCount++;
            }
            
            //10点配置
            if(Mato1Count < Mato1CountMax)
            {
                GameObject Mato1 = GameObject.Instantiate(Mato1Prefab);
                Vector3 PosTemp = ObstacleMain.transform.position;
                PosTemp.x+=Random.Range((float)0,(float)10);
                PosTemp.y+=Random.Range(3,10);
                Mato1.transform.position=PosTemp;
                Mato1Count++;
            }
            
            //1点配置
            if(Mato2Count < Mato2CountMax)
            {
                GameObject Mato2 = GameObject.Instantiate(Mato2Prefab);
                Vector3 PosTemp = ObstacleMain.transform.position;
                PosTemp.x+=5;
                PosTemp.y+=6;
                Mato2.transform.position=PosTemp;
                Mato2Count++;
            }
            
            //ワープ配置
            if(WarpCount < WarpCountMax)
            {
                GameObject Warp = GameObject.Instantiate(WarpPrefab);
                Vector3 PosTemp = ObstacleMain.transform.position;
                PosTemp.x+=warpPos;
                PosTemp.y+=1;
                Warp.transform.position=PosTemp;
                WarpCount++;
                warpPos+=10;
            }

            //初期玉配置
            if(BallCount<5){
                AddBall();
            }
            else if(KugiCount==KugiCountMax&&WindmillCount==WindmillCountMax){
                gameMode=1;
            }

        }
        if(gameMode==1){

            //全滅ゲームオーバー
            if(BallCount<=0&&gameMode==1){
                gameMode=2;
                Debug.Log("GAME OVER");
            }

            //時間切れゲームオーバー
            if(gameTimer<0){
                gameMode=2;
                Debug.Log("Time Up");
            }

            scoreText.text=("Score:"+Score);
            sli.value=gameTimer;

            gameTimer--;

        }
        if(gameMode==2){
            //リザルトへ切り替え
            SceneManager.LoadScene("Result");
        }

    }

    public void AddBall()
    {
        GameObject Ball = GameObject.Instantiate(BallPrefab);
        Vector3 PosTemp = BallPrefab.transform.position;
        PosTemp.x+=Random.Range((float)-5,(float)4);
        Ball.transform.position=PosTemp;
        BallCount++;
    }

    public int getScore()
    {
        return Score;
    }
}
