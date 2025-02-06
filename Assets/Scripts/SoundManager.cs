using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public GameObject BtnSoundsOff;
    public GameObject BtnSoundsOn;
    private int IsSoundOff;
    public void SoundSwitch()
    {
        IsSoundOff = PlayerPrefs.GetInt("IsSoundOff");
        if (IsSoundOff == 0)
        {
            IsSoundOff = 1;
            PlayerPrefs.SetInt("IsSoundOff", IsSoundOff);
            AudioListener.volume = 0f;
            BtnSoundsOff.SetActive(false);
            BtnSoundsOn.SetActive(true);
        }
        else if (IsSoundOff == 1)
        {
            IsSoundOff = 0;
            PlayerPrefs.SetInt("IsSoundOff", IsSoundOff);
            AudioListener.volume = 1f;
            BtnSoundsOff.SetActive(true);
            BtnSoundsOn.SetActive(false);
        }
    }
}
