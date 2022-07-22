using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public int TotalCoin;
    private void Awake()
    {
        instance = this;
        TotalCoin = PlayerPrefs.GetInt("totalcoin");
    }
    public void CoinAdd(int amount)
    {
        TotalCoin = TotalCoin + amount;
        PlayerPrefs.SetInt("totalcoin", TotalCoin);
    }
    public void RemoveCoin(int amount)
    {
        if (TotalCoin >= amount)
        {
            TotalCoin = TotalCoin - amount;
            PlayerPrefs.SetInt("totalcoin", TotalCoin);
        }
        else
        {
            Debug.Log("Not Enough Coin");
        }
    }
    
}
