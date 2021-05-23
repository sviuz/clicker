
using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour {
    [SerializeField] private Text scoreText;
    [SerializeField] private Text levelText;
    [SerializeField] private Button Click;
    [SerializeField] private GameObject ClickPrefab;
    [SerializeField] private GameObject ClickGenerator;
    private ClickObject[] clickObjectsPool = new ClickObject[15];
    private int clickCounter = 0;
    private int i;
    private PlayerInfo _playerInfo;

    private void Start() {
        _playerInfo = new PlayerInfo();
        for (int i = 0; i < clickObjectsPool.Length; i++) {
            clickObjectsPool[i] = Instantiate(ClickPrefab, ClickGenerator.transform).GetComponent<ClickObject>();
        }
        Click.onClick.AddListener(ClickHandler);
        scoreText.text = _playerInfo.GetCoins().ToString();
        levelText.text = _playerInfo.GetLevel().ToString();
    }

    private void ClickHandler() {
        AddCoin();
        PrefabPooling();
        scoreText.text = string.Empty;
        scoreText.text = _playerInfo.GetCoins().ToString();
    }
    
    private void AddCoin() {
        i = Random.Range(1, 5);
        _playerInfo.AddCoins(i);
        scoreText.text = _playerInfo.GetCoins().ToString();
    }

    private void PrefabPooling() {
        clickObjectsPool[clickCounter].StartMotion(i);
        clickCounter++;
        clickCounter = clickCounter == clickObjectsPool.Length -1 ? 0 : clickCounter++;
    }

    
}
