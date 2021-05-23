using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button pauseButton;
    void Start() {
        pauseButton.onClick.AddListener(() => pausePanel.SetActive(true));
    }
}
