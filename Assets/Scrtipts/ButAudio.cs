using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButAudio : MonoBehaviour{
    [SerializeField] private AudioSource clickSound;

    public void OnButtonClick() => StartCoroutine(PlayClickSound());

    private IEnumerator PlayClickSound() {
        clickSound.Play();
        yield return new WaitForSeconds(0.2f); 
    }
}
