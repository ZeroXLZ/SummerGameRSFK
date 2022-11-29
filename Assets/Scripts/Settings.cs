using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;
    public AudioMixer mixer;
    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MasterVolume", 0.75f);
        dropdown.value = PlayerPrefs.GetInt("GraphicsLevel");
        QualitySettings.SetQualityLevel(dropdown.value, true);
    }
    public void changeGraphicsLevel()
    {
        QualitySettings.SetQualityLevel(dropdown.value, true);
        PlayerPrefs.SetInt("GraphicsLevel", dropdown.value);
    }
    public void SetVolume()
    {
        float sliderValue = slider.value;
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
    }
}
