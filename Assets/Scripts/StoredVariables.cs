using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class StoredVariables : MonoBehaviour
{
    public static bool hasSword = false;
    public Slider slider = null;
    public static float gameVolume = 100;
    public float volumeDisplay = 100;
    public static float maxVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volumeDisplay = gameVolume;
        if (slider != null)
        {
            slider.value = gameVolume;
        }
        if (hasSword == true)
        {
            Sword.playerSword.SetActive(true);
        }
        else
        {
            Sword.playerSword.SetActive(false);
        }
    }
    public static void SetVolume(Slider slider)
    {
        gameVolume = slider.value;
        AudioListener.volume = maxVolume * (gameVolume/100);
    }
    public static void GivePlayerSword()
    {
        hasSword = true;
    }
}
