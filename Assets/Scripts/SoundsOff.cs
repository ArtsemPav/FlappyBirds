using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SoundsOff : MonoBehaviour
{
    public GameObject Sounds;

    public void SoundSwitch()
    {
        if (Sounds.activeSelf == true)
        {
            AudioListener.volume = 0f;
            Sounds.SetActive(false);
        }
        else
        {
            AudioListener.volume = 1f;
            Sounds.SetActive(true);
        }
    }
}
