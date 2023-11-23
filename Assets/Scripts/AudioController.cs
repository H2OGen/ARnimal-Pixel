using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource button;
    public void PlaySFX()
    {
        button.Play();
        Debug.Log(button.name);
    }

    public void PlaySFXInput(AudioSource sFX)
    {
        sFX.Play();
    }
}
