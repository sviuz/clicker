using UnityEngine;
using UnityEngine.UI;

public class TopPanel : MonoBehaviour {
    public static TopPanel Instance;
    private Text scoreText;
    //[SerializeField] private Text levelText;
    private PlayerInfo _playerInfo;

    private void Start() {
        _playerInfo = new PlayerInfo();
        GameObject.FindWithTag("Score");
    }

    public void RefreshTopPanel() {
        
    }


}
