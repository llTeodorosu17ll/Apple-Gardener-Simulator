using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour{

    public Text highScore;

    void Start(){
        int value = PlayerPrefs.GetInt("high_score", 0);
        highScore.text = value.ToString();
    }

    void Update(){
        
    }

}
