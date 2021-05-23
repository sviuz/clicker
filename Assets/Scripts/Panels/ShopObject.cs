using UnityEngine;
using UnityEngine.UI;

public class ShopObject : MonoBehaviour {
    [SerializeField] private Button buy;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text price;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject InfoPanel;
    private PlayerInfo _playerInfo;
    void Start() {
        _playerInfo = new PlayerInfo();
        buy.onClick.AddListener(()=>Purchase(int.Parse(price.text)));
    }

    private void Purchase(int value) {
        PlayerInfo.Instance.RemoveCoins(value);
        scoreText.text = string.Empty;
        scoreText.text = _playerInfo.GetCoins().ToString();
    }
    
}
