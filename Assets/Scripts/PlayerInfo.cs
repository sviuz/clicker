using System;
using UnityEngine;

[Serializable]
public class PlayerInfo : MonoBehaviour{
    public static PlayerInfo Instance;
    private void Awake() {
        if (Instance== null) {
            Instance = this;
        }else if (Instance == this) {
            Destroy(gameObject);
        }
        if (!PlayerPrefs.HasKey("user_coins")) {
            PlayerPrefs.SetInt("user_coins",0);
        }
        if (!PlayerPrefs.HasKey("user_coins_per_sec")) {
            PlayerPrefs.SetInt("user_coins_per_sec",0);
        }
    }

   

    public int GetCoins() => PlayerPrefs.GetInt("user_coins");
    public int GetLevel() => PlayerPrefs.GetInt("user_coins_per_sec");
    
    public void AddCoins(int value) {
        
        
        
        var currentAmount = PlayerPrefs.GetInt("user_coins");
        currentAmount += value;
        PlayerPrefs.SetInt("user_coins", currentAmount);
        PlayerPrefs.Save();
    }

    public void RemoveCoins(int value) {
        var currentAmount = PlayerPrefs.GetInt("user_coins");
        currentAmount -= value;
        PlayerPrefs.SetInt("user_coins", currentAmount);
        PlayerPrefs.Save();
    }

    public void AddCoinsPerSec(int coins) {
        var currentCoins = PlayerPrefs.GetInt("user_coins_per_sec");
        currentCoins += coins;
        PlayerPrefs.SetInt("user_coins_per_sec", currentCoins);
        PlayerPrefs.Save();
    }
}
