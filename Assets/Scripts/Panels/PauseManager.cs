using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour {
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resume;
    [SerializeField] private Button shop;
    [SerializeField] private GameObject shopPanel;
    void Start()
    {
        resume.onClick.AddListener(()=>pausePanel.SetActive(false));
        shop.onClick.AddListener(()=>shopPanel.SetActive(true));
    }
}
