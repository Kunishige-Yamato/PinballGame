using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedCoin : MonoBehaviour
{
    ChangeBallSkin cbs;
    ChangeBackgroundSkin cbgs;

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject bg4;
    public GameObject bg5;
    public GameObject bg6;

    void Start()
    {
        cbs=b1.GetComponent<ChangeBallSkin>();
        cbs.needCoin=0;
        cbs=b2.GetComponent<ChangeBallSkin>();
        cbs.needCoin=6000;
        cbs=b3.GetComponent<ChangeBallSkin>();
        cbs.needCoin=2000;
        cbs=b4.GetComponent<ChangeBallSkin>();
        cbs.needCoin=8000;
        cbs=b5.GetComponent<ChangeBallSkin>();
        cbs.needCoin=4000;
        cbs=b6.GetComponent<ChangeBallSkin>();
        cbs.needCoin=10000;

        cbgs=bg1.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=0;
        cbgs=bg2.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=5500;
        cbgs=bg3.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=1500;
        cbgs=bg4.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=7500;
        cbgs=bg5.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=3500;
        cbgs=bg6.GetComponent<ChangeBackgroundSkin>();
        cbgs.needCoin=9500;
    }

    void Update()
    {

    }
}
