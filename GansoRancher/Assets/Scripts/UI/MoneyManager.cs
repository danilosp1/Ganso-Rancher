using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{

    public Text moneyText;
    public int currentMoney;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("CurrentMoney")){
            currentMoney = PlayerPrefs.GetInt("CurrentMoney");
        } else {
            currentMoney = 0;
            PlayerPrefs.SetInt("CurrentMoney", 0);
        }

        moneyText.text = "Money: " + currentMoney;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney(int qtd){
        currentMoney += qtd;
        PlayerPrefs.SetInt("CurrentMoney", currentMoney);
        moneyText.text = "Money: " + currentMoney;
    }

    public void RemoveMoney(int qtd){
        currentMoney -= qtd;
        PlayerPrefs.SetInt("CurrentMoney", currentMoney);
        moneyText.text = "Money: " + currentMoney;
    }
}
