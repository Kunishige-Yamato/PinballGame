using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public int money;
    public Text moneyText;

    void Start()
    {

    }

    void Update()
    {
        money=PlayerPrefs.GetInt("MONEY");
        moneyText.text=(""+money);
    }
}
