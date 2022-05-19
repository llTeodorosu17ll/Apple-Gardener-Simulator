using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleScript : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    public Timer timerScript;

    public bool inGame;

    private void Start(){
        inGame = true;
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Bonus"){
            Destroy(other.gameObject);
            timerScript.AddSecond();
            if (inGame){
                score++;
            }
        }
    }

    void Update(){
        scoreText.text = score.ToString();
    }
}
