using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOff : MonoBehaviour
{
    public GameObject Sounds;
    public void SoundSwitch()
    {
        if (Sounds.activeSelf == true)
        {
            Sounds.SetActive(false);
        }
        else
        {
            Sounds.SetActive(true);
        }
    }
}
