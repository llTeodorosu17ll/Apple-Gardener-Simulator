using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{

    [SerializeField] private float duration;
    [SerializeField] private Text Secunder;
    [SerializeField] private Игрок player;
    [SerializeField] private int delay;
    private int timer;
    [SerializeField] private AppleScript appleScript;
    [SerializeField] private GameObject TimeUp;
    

    public void AddSecond(){
        timer++;
        Secunder.text = timer.ToString();
    }

    private void Start(){
        timer = PlayerPrefs.GetInt("delay",delay);
        StartCoroutine(MyTimer());
    }
    private IEnumerator MyTimer(){
        while (timer > 0){
            yield return new WaitForSeconds(duration);
            Debug.Log("Time is up" + timer);
            timer--;
            Secunder.text = timer.ToString();
        }
        if (timer == 0){
            player.isPlaying = false;
            PlayerPrefs.SetInt("high_score", appleScript.score);
            TimeUp.SetActive(true);
        }
    }


}
