using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Пила : MonoBehaviour{

    public float speed = 2f;
    public bool direction = true;


    void Fixedupdate(){
        transform.Rotate(0f, 0f, speed * (direction ? 1 : -1));
    }






}
