using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class ClickCheck : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed = false;
    public float pressThreshold = 1.0f;
    private float pressTime;
    public Button Button1;
    public Main MainScript;
    public BSPriceChange CBS;


    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true; // устанавливаем флаг, что кнопка зажата
        pressTime = 0.0f; // обнуляем время зажатия
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false; // срасываем флаг, что кнопка зажата
        pressTime = 0.0f; // обнуляем время зажатия
    }



    // Start is called before the first frame update
    void Start()
    {
        MainScript.button1 = Button1.GetComponent<Button>();
        //MainScript = GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed) // если кнопка зажата
        {
            pressTime += Time.deltaTime; // увеличиваем время зажатия
            if (pressTime >= pressThreshold && MainScript.NumberBTN == 1) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedFirstBTN;
                MainScript.button1.spriteState = spriteState;




                /*MainScript.Buttons.sprite = MainScript.PressedFirstBTN;*/
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 2) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedSecondBTN;
                MainScript.button1.spriteState = spriteState;
            }

            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 3) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedThirdBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 4) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedFourBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 5) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedFiveBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 6) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedSixBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 7) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedSevenBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 8) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedEightBTN;
                MainScript.button1.spriteState = spriteState;
            }
            else if (pressTime >= pressThreshold && MainScript.NumberBTN == 9) // если кнопка зажата достаточно долго
            {
                SpriteState spriteState = new SpriteState();
                spriteState.pressedSprite = MainScript.PressedNineBTN;
                MainScript.button1.spriteState = spriteState;
            }
        }
    }
}

