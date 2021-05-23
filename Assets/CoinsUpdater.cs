using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsUpdater : MonoBehaviour
{
    public float timeRemaining = 60f;
    void Start () {
 
    }
 
    void Update () {
        if (timeRemaining > 0) {
            Debug.Log("Waitting..."+timeRemaining);
            timeRemaining -= Time.deltaTime;
            if ( timeRemaining == 0 ) { AddCoins(); }
        } 
    }
 
    void AddCoins(){
        
    }
}
