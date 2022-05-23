using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volSliderHandler : MonoBehaviour
{
    public optionsManager manager;
    public AudioMixer mixer;   
    public void SetVol(float sliderValue){
        manager.volume = sliderValue;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

}
