using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTaker : MonoBehaviour{

    public int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Bonus"){
            Destroy(other.gameObject);
            score++;
        }
    }

    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        scoreText.text = score.ToString();
    }
}
