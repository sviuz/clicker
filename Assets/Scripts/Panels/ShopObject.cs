using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopObject : MonoBehaviour {
    [SerializeField] private Button buy;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text price;
    [SerializeField] private Text coinsPerSec;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject InfoPanel;
    void Start() {
        buy.onClick.AddListener(()=>Purchase(int.Parse(price.text)));
    }

    private void Purchase(int value) {
        PlayerInfo.Instance.RemoveCoins(value);
        scoreText.text = string.Empty;
        scoreText.text = PlayerInfo.Instance.GetCoins().ToString();
        PlayerInfo.Instance.AddCoinsPerSec(int.Parse(coinsPerSec.text));
        levelText.text = string.Empty;
        levelText.text = PlayerInfo.Instance.GetLevel().ToString();
    }
    
}
