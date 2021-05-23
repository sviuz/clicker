using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour {
    [SerializeField] private GameObject shopPanel;
    [SerializeField] private Button goBack;
    void Start() {
        goBack.onClick.AddListener(()=>shopPanel.SetActive(false));
    }
    
    
}
