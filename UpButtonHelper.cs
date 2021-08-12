using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UpButtonHelper : MonoBehaviour
{
    public Text DamageText;
    public Text PriceText;
    public int Damage = 5;
    public GameObject UpgradePanel;

    public int[] CostInt;
    public Text[] CostText;


    GameHelper _gameHelper;
    // Start is called before the first frame update
    void Start()
    {
       _gameHelper = GameObject.FindObjectOfType<GameHelper>();
        /* DamageText.text = "+" + Damage.ToString();
         PriceText.text = Price.ToString(); */
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowAndHideUpgradePanel()
    {
        UpgradePanel.SetActive(!UpgradePanel.activeSelf);
    }
    public void OnClickBuyUp()
    {
        if (_gameHelper.PlayerGold >= CostInt[0])
        {
            _gameHelper.PlayerGold -= CostInt[0];
            _gameHelper.PlayerDamage += Damage;
            CostInt[0] *= 2;
            Damage *= 2;

            CostText[0].text = CostInt[0].ToString();
        }
    }

    /*public void UpClick()
    {
        if (_gameHelper.PlayerGold >= Price)
        {
            _gameHelper.PlayerGold -= Price;
            _gameHelper.PlayerDamage += Damage;

            Destroy(gameObject);
        }
    }*/







   
}
