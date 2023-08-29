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

public class Sounds : MonoBehaviour
{
    [SerializeField]
    public Main MainScript;
    public AudioClip[] BackVoice;
    public AudioSource VoiceManager;
    public AudioClip[] ButtonVoice;
    public AudioSource VoiceButtnManager;
    private static Sounds instance;
    public int PrevGround;
    public int PrevButtons;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // ������������� ����������� ������� ��� �������� ����� �����
            //SceneManager.sceneLoaded += OnSceneLoaded; // ������������� �� ������� sceneLoaded "��������� � �������� ����(�������� ��� ����� �����)"
        }
        else
        {
            Destroy(gameObject); // ���������� ������������� ���������
        }
    }

   
    void Update()/*OnSceneLoaded(Scene scene, LoadSceneMode mode)"�������� ����-��� ����(�������� ��� ����� �����)"*/
    {
        
        MainScript = GameObject.FindObjectOfType<Main>();

        if (MainScript != null)
        {
            //����� ����
            if (Main.NBG == 1 && Main.NBG != PrevGround) // Vladik
            {
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[0];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }

            if (Main.NBG == 2 && Main.NBG != PrevGround) // space
            {
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[1];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }

            if (Main.NBG == 3 && Main.NBG != PrevGround) // japan
            {
                VoiceManager.Stop();
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[3];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }

            if (Main.NBG == 7 && Main.NBG != PrevGround) // mountain
            {
                VoiceManager.Stop();
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[4];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }

            if (Main.NBG == 5 && Main.NBG != PrevGround) // wall
            {
                VoiceManager.Stop();
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[2];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }

            if (Main.NBG == 6 && Main.NBG != PrevGround) // taina 
            {
                VoiceManager.Stop();
                VoiceManager.loop = true; // ������������� loop � true
                VoiceManager.clip = BackVoice[5];
                VoiceManager.Play();
                PrevGround = Main.NBG;
            }



            //����� ������
            if (Main.NBB == 1 && Main.NBB != PrevButtons) //Cat
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[5];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 2 && Main.NBB != PrevButtons) //planet
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[2];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 3 && Main.NBB != PrevButtons) //Flower
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[4];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 4 && Main.NBB != PrevButtons) //FirstButton
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[0];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 5 && Main.NBB != PrevButtons) //Bird
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[1];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 6 && Main.NBB != PrevButtons) //Spray
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[3];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 7 && Main.NBB != PrevButtons) //Secret
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[9];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 8 && Main.NBB != PrevButtons) //Finger
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[7];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

            if (Main.NBB == 9 && Main.NBB != PrevButtons) //Tent
            {
                VoiceButtnManager.Stop();
                VoiceButtnManager.loop = true; // ������������� loop � true
                VoiceButtnManager.clip = ButtonVoice[8];
                VoiceButtnManager.Play();
                PrevGround = Main.NBB;
            }

        }

    }

}
