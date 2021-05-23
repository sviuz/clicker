using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelManager : MonoBehaviour {
    [SerializeField] private Button close;
    [SerializeField] private GameObject panel;
    void Start()
    {
        close.onClick.AddListener(()=>panel.SetActive(false));
    }
}
