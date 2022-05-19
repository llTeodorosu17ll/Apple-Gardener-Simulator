using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Монетка : MonoBehaviour{

    public float speed = 2f;
    public bool direction = true;

    float yMin;

    void Start(){
        yMin = transform.position.y;
    }

    void Fixedupdate(){
        if (transform.position.y > yMin + 1) {
            direction = false;
        } else if (transform.position.y < yMin) {
            direction = true;
        }
        float delta = speed * (direction ? 1 : -1) * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);


    }

}
