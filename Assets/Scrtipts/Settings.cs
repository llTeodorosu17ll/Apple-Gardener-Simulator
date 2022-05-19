using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour{
    
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider songSlider;

    private void Start() {
        float value;
        audioMixer.GetFloat("GameSong", out value);
        songSlider.value = value;
    }

    public void OnVolumeChanged(float volume) {
        audioMixer.SetFloat("GameSong", volume);
    }

}
