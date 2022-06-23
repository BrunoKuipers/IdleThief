using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneyEarner : MonoBehaviour
{
    private int _coins;
    
    [SerializeField]
    private int _coinsMultiplier;
    
    [SerializeField]
    private TMP_Text _coinsText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("coins"))
       {
           _coins = PlayerPrefs.GetInt("coins");
           _coinsText.text = _coins.ToString(); 
       }
        
    
    }

    public void EarnMoney()
    {
        _coins+= _coinsMultiplier;
        PlayerPrefs.SetInt("coins", _coins);
        _coinsText.text = _coins.ToString();
    }
}
