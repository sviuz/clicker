using UnityEngine;
using UnityEngine.UI;

public class FirstClick : MonoBehaviour {
    [SerializeField] private Text click;
    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            click.gameObject.SetActive(false);
        }); ;

    }
}
