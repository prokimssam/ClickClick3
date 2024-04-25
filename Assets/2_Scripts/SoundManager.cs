using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    public static SoundManager Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    public void Sound(Define.Sound sound)
    {
        audioSource.clip = audioClips[(int)sound];
        audioSource.Play();
    }

    private void Start()
    {
        SoundManager.Instance.Sound(Define.Sound.Attack);
    }

}
