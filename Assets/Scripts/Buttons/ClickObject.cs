using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {
    [SerializeField] private Text scoreText;
    private bool isMoving;
    private Vector2 randVector2;
    
    private void Update() {
        if (!isMoving)return;
        transform.Translate(randVector2*Time.deltaTime);
    }

    public void StartMotion(int inc) {
        transform.position = Vector2.zero;
        randVector2 = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        scoreText.text = "+" + inc;
        isMoving = true;
        
    }
}
