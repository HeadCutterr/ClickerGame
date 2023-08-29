using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using static System.Random;

public class SoundsManager : MonoBehaviour
{
    public Main MainScript;
    public AudioClip[] BackVoice;
    public AudioSource VoiceManager;


    public static SoundsManager Instance { get; private set; }
    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void PlaySound()
    {
        if (MainScript.NumberGround == 1)
        {
            VoiceManager.loop = true; // Установите loop в true
            VoiceManager.clip = BackVoice[0];
            VoiceManager.Play();
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
