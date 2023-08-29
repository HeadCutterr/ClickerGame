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

public class Main : MonoBehaviour
{
    /* Сделать рекламу на все кнопки магаза*/
    [SerializeField] int money;
    public Text moneyText;
    public Text CMonet;
    public Text CCost;
    public Text Reb;
    public Text MTimeTxt;
    public Text RebText;
    public Text g2t;
    public Text g3t;
    public Text g4t;
    public Text g5t;
    public Text g6t;
    public Text HowManyClicks;
    public Text HowManyRebs;
    public Text AchievCount;
    public Text ShopText;
    public Text MenuText;
    public Text ButtonShopText;
    public Text BackgroundShopText;
    public Text Grade1Text;
    public Text Grade2Text;
    public Text Grade3Text;
    public Text Grade4Text;
    public Text Grade5Text;
    public Text Grade6Text;
    public Text GradeRebText;
    public Text RebcountTextText;
    public Text PerClickStringShop;
    public Text MoneyStringShop;
    public Text AchievText;
    public Text AchievClickText;
    public Text AchivRebText;
    public Text LanguageSelect;
    public Text SecretText;
    public Text ShopClick;
    public Text SecretShop;
    public string GradeClicks;
    public string GradeRebs;
    public int Rebcost = 1000000000;
    public int Costint = 10;
    public int g2 = 1000;
    public int g3 = 100000;
    public int g4 = 1000000;
    public int g5 = 2000000;
    public int g6 = 20000000;
    public int CMoney = 2;
    public int Rebcount = 0;
    public int MTime = 0;
    public int GrowMT = 11000;
    public int GrowMM = 0;
    public double CGrowMT = 1000;
    public double CGrowMM = 1000;
    public int NumberGround = 1;
    public int NumberBTN = 1;
    public int NumberClick = 0;
    public int NumberReb = 0;
    public int AllAchievs;
    public int Language = 0;
    public int Nclick;
    public int RCount;
    public GameObject skin;
    public Image Background;
    public Image Buttons;
    public Image BuyB;
    public Image BuyBPlanet;
    public Image BuyBFlower;
    public Image BuyBKitty;
    public Image BuyBBird;
    public Image BuyBSpray;
    public Image PressedBuyBPlanet;
    public Image PressedBuyBFlower;
    public Image PressedBuyBKitty;
    public Image PressedBuyBBird;
    public Image PressedBuyBSpray;
    public Image PressedBCGStandart;
    public Image BCGJapan;
    public Image BCGMountain;
    public Image BCGStandart;
    public Image BCGSpace;
    public Image BCGWall;
    public Image BCGMisteryBCG;
    public Image CupsClick;
    public Image CupsReb;
    public Image SecretButton;
    public Image MisteryBCG;
    public Image MisteryBTN;
    public Sprite SecretButtonSprite;
    public Sprite NoClick;
    public Sprite BronzeClick;
    public Sprite SilverClick;
    public Sprite GoldClick;
    public Sprite BronzeReb;
    public Sprite SilverReb;
    public Sprite GoldReb;
    public Sprite BuyBLock;
    public Sprite BuyBUnlock;
    public Sprite FirstGround;
    public Sprite SecondGround;
    public Sprite ThirdGround;
    public Sprite FourGround;
    public Sprite FiveGround;
    public Sprite FirstBTN;
    public Sprite SecondBTN;
    public Sprite ThirdBTN;
    public Sprite FourBTN;
    public Sprite FiveBTN;
    public Sprite SixBTN;
    public Sprite SevenBTN;
    public Sprite EightBTN;
    public Sprite NineBTN;
    public Sprite SixBCG;
    public Sprite SevenBCG;
    public Sprite PressedFirstBTN;
    public Sprite PressedSecondBTN;
    public Sprite PressedThirdBTN;
    public Sprite PressedFourBTN;
    public Sprite PressedFiveBTN;
    public Sprite PressedSixBTN;
    public Sprite PressedSevenBTN;
    public Sprite PressedEightBTN;
    public Sprite PressedNineBTN;
    public Sprite BuyButton;
    public Sprite BuyButtonRus;
    public Sprite BuyMountButton;
    public Sprite BuyMountButtonRus;
    public Sprite BuySpaceButton;
    public Sprite BuySpaceButtonRus;
    public Sprite BuyJapanButton;
    public Sprite BuyJapanButtonRus;
    public Sprite BuyWallButton;
    public Sprite BuyWallButtonRus;
    public Sprite BuyMisteryButton;
    public Sprite BuyMisteryButtonRus;
    public Sprite SelectButton;
    public Sprite SelectSpaceButton;
    public Sprite SelectJapanButton;
    public Sprite SelectWallButton;
    public Sprite SelectButtonRus;
    public Sprite SelectSpaceButtonRus;
    public Sprite SelectJapanButtonRus;
    public Sprite SelectWallButtonRus;
    public Sprite SelectMisteryButton;
    public Sprite SelectMisteryButtonRus;
    public Sprite SelectMountButton;
    public Sprite SelectMountButtonRus;
    public Sprite ShopButton;
    public Sprite ShopButtonRus;
    public Sprite ShopMountButton;
    public Sprite ShopMountButtonRus;
    public Sprite ShopSpaceButton;
    public Sprite ShopSpaceButtonRus;
    public Sprite ShopJapanButton;
    public Sprite ShopJapanButtonRus;
    public Sprite ShopWallButton;
    public Sprite ShopWallButtonRus;
    public Sprite ShopMisteryButton;
    public Sprite ShopMisteryButtonRus;
    public Sprite AchievmentButton;
    public Sprite AchievmentSpaceButton;
    public Sprite AchievmentJapanButton;
    public Sprite AchievmentWallButton;
    public Sprite AchievmentMountButton;
    public Sprite AchievmentMountButtonRus;
    public Sprite AchievmentButtonRus;
    public Sprite AchievmentSpaceButtonRus;
    public Sprite AchievmentJapanButtonRus;
    public Sprite AchievmentWallButtonRus;
    public Sprite AchievmentMisteryButton;
    public Sprite AchievmentMisteryButtonRus;
    public Sprite ButtonsButton;
    public Sprite ButtonsSpaceButton;
    public Sprite ButtonsJapanButton;
    public Sprite ButtonsWallButton;
    public Sprite ButtonsMountButton;
    public Sprite ButtonsMountButtonRus;
    public Sprite ButtonsButtonRus;
    public Sprite ButtonsSpaceButtonRus;
    public Sprite ButtonsJapanButtonRus;
    public Sprite ButtonsWallButtonRus;
    public Sprite ButtonsMisteryButton;
    public Sprite ButtonsMisteryButtonRus;
    public Sprite BackgroundsButton;
    public Sprite BackgroundsSpaceButton;
    public Sprite BackgroundsJapanButton;
    public Sprite BackgroundsWallButton;
    public Sprite BackgroundsMountButton;
    public Sprite BackgroundsMountButtonRus;
    public Sprite BackgroundsButtonRus;
    public Sprite BackgroundsSpaceButtonRus;
    public Sprite BackgroundsJapanButtonRus;
    public Sprite BackgroundsWallButtonRus;
    public Sprite BackgroundsMysteryButton;
    public Sprite BackgroundsMysteryButtonRus;
    public Sprite MenuButton;
    public Sprite MenuMountButton;
    public Sprite MenuMountButtonRus;
    public Sprite MenuSpaceButton;
    public Sprite MenuJapanButton;
    public Sprite MenuWallButton;
    public Sprite MenuButtonRus;
    public Sprite MenuSpaceButtonRus;
    public Sprite MenuJapanButtonRus;
    public Sprite MenuWallButtonRus;
    public Sprite MenuMisteryButton;
    public Sprite MenuMisteryButtonRus;
    public Sprite HomeButton;
    public Sprite HomeMountButton;
    public Sprite HomeSpaceButton;
    public Sprite HomeJapanButton;
    public Sprite HomeWallButton;
    public Sprite HomeMisteryButton;
    public Sprite AboutUsButton;
    public Sprite AboutUsMountButton;
    public Sprite AboutUsMountButtonRus;
    public Sprite AboutUsSpaceButton;
    public Sprite AboutUsjapanButton;
    public Sprite AboutUsWallButton;
    public Sprite AboutUsButtonRus;
    public Sprite AboutUsSpaceButtonRus;
    public Sprite AboutUsjapanButtonRus;
    public Sprite AboutUsWallButtonRus;
    public Sprite AboutUsMisteryButton;
    public Sprite AboutUsMisteryButtonRus;
    private Sprite currentSprite;
    private Sprite currentButtonSprite;
    public Sprite LanguageB;
    public Sprite LanguageBMount;
    public Sprite LanguageBMountRus;
    public Sprite LanguageBSpace;
    public Sprite LanguageBJapan;
    public Sprite LanguageBWall;
    public Sprite LanguageBRus;
    public Sprite LanguageBSpaceRus;
    public Sprite LanguageBJapanRus;
    public Sprite LanguageBWallRus;
    public Sprite LanguageBMistery;
    public Sprite LanguageBMisteryRus;
    public Sprite RussianLang;
    public Sprite RussianMountLang;
    public Sprite RussianSpaceLang;
    public Sprite RussianJapanLang;
    public Sprite RussianWallLang;
    public Sprite RussianMisteryLang;
    public Sprite EnglishLang;
    public Sprite EnglishMountLang;
    public Sprite EnglishSpaceLang;
    public Sprite EnglishJapanLang;
    public Sprite EnglishWallLang;
    public Sprite EnglishMisteryLang;
    public Sprite MisteryShopBCG;
    public Sprite MisteryShopBCGMount;
    public Sprite MisteryShopBCGMountRus;
    public Sprite MisteryShopBCGSpace;
    public Sprite MisteryShopBCGJapan;
    public Sprite MisteryShopBCGWall;
    public Sprite MisteryShopBCGRus;
    public Sprite MisteryShopBCGSpaceRus;
    public Sprite MisteryShopBCGJapanRus;
    public Sprite MisteryShopBCGWallRus;
    public Sprite SecretB;
    public Sprite SecretBMount;
    public Sprite SecretBMountRus;
    public Sprite SecretBSpace;
    public Sprite SecretBJapan;
    public Sprite SecretBWall;
    public Sprite SecretBRus;
    public Sprite SecretBSpaceRus;
    public Sprite SecretBJapanRus;
    public Sprite SecretBWallRus;
    public Sprite SecretBMistery;
    public Sprite SecretBMisteryRus;
    public Sprite REKLAMASUN;
    public Sprite REKLAMABANKA;
    public Sprite REKLAMATOOLS;
    public Sprite REKLAMASUN_Rus;
    public Sprite REKLAMABANKA_Rus;
    public Sprite REKLAMATOOLS_Rus;
    public Button button1;
    public GameObject popupPanel;
    public GameObject popupPanel2;
    public GameObject popupPanel3;
    public string url;
    public string RebString;
    public string PerClickString;
    public BSPriceChange CBS;
    public Sprite CompleteFirst;
    public Sprite CompleteSecond;
    public Sprite CompleteThird;
    public Sprite CompleteFour;
    public Sprite CompleteFive;
    public Sprite CompleteSix;




    public void Randomizer()
    {
        System.Random random = new System.Random(DateTime.Now.Millisecond);
        int RCount = random.Next(1, 101);
        if (RCount >= 10 && RCount <= 20 && Language == 1)
        {
            SceneManager.LoadScene(8);
        }
        else if (RCount >= 10 && RCount <= 20 && Language == 0)
        {
            SceneManager.LoadScene(9);
        }

        if (RCount >= 21 && RCount <= 31 && Language == 1)
        {
            SceneManager.LoadScene(10);
        }
        else if (RCount >= 21 && RCount <= 31 && Language == 0)
        {
            SceneManager.LoadScene(11);
        }

        if (RCount >= 32 && RCount <= 42 && Language == 1)
        {
            SceneManager.LoadScene(12);
        }
        else if (RCount >= 32 && RCount <= 42 && Language == 0)
        {
            SceneManager.LoadScene(13);
        }
    }


    public void EnglishLanguage()
    {
        Language = 0;
    }

    public void RussianLanguage()
    {
        Language = 1;
    }




    public void ShowPopup()
    {
        if (AllAchievs == 6)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            popupPanel.SetActive(true);
            popupPanel2.SetActive(true);
            popupPanel3.SetActive(true);
        }
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        popupPanel2.SetActive(false);
        popupPanel3.SetActive(false);
    }


    public void OpenSite()
    {
        Application.OpenURL(url);
    }



    public void PointerDown()
    {
        if (NumberBTN == 1)
        {
            Buttons.sprite = PressedFirstBTN;
            Debug.Log("Nope");
        }


    }

    /*public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true; // устанавливаем флаг, что кнопка зажата
        pressTime = 0.0f; // обнуляем время зажатия
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false; // срасываем флаг, что кнопка зажата
        pressTime = 0.0f; // обнуляем время зажатия
    }
    */

    public void ButtonClick()
    {
        money += CMoney;
        if (Rebcount >= 1)
        {
            Nclick++;
        }
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        /*System.Random random = new System.Random(DateTime.Now.Millisecond);
        int RCount = random.Next(1, 201);
        if (RCount >= 10 && RCount <= 20 && Language == 1)
        {
            SceneManager.LoadScene(8);
        }
        else if (RCount >= 10 && RCount <= 20 && Language == 0)
        {
            SceneManager.LoadScene(9);
        }

        if (RCount >= 21 && RCount <= 31 && Language == 1)
        {
            SceneManager.LoadScene(10);
        }
        else if (RCount >= 21  && RCount <= 31 && Language == 0)
        {
            SceneManager.LoadScene(11);
        }

        if (RCount >= 32 && RCount <= 42 && Language == 1)
        {
            SceneManager.LoadScene(12);
        }
        else if (RCount >= 32 && RCount <= 42 && Language == 0)
        {
            SceneManager.LoadScene(13);
        }*/
    }


    public void Start()
    {
        popupPanel.SetActive(false);
        popupPanel2.SetActive(false);
        popupPanel3.SetActive(false);
        money = PlayerPrefs.GetInt("money");
        Rebcount = PlayerPrefs.GetInt("Rebcount");
        CMoney = PlayerPrefs.GetInt("CMoney");
        Costint = PlayerPrefs.GetInt("Costint");
        g2 = PlayerPrefs.GetInt("g2");
        g3 = PlayerPrefs.GetInt("g3");
        g4 = PlayerPrefs.GetInt("g4");
        g5 = PlayerPrefs.GetInt("g5");
        g6 = PlayerPrefs.GetInt("g6");
        Nclick = PlayerPrefs.GetInt("Nclick");
        NumberGround = PlayerPrefs.GetInt("NumberGround");
        NumberBTN = PlayerPrefs.GetInt("NumberBTN");
        Language = PlayerPrefs.GetInt("Language");


        //skin = GameObject.Find("");

        // постоянное обновление фона
        if (NumberGround == 1)
        {
            Background.sprite = FirstGround;
            Debug.Log("Est");
        }
        else if (NumberGround == 2)
        {
            Background.sprite = SecondGround;
            Debug.Log("Est");
        }
        else if (NumberGround == 3)
        {
            Background.sprite = ThirdGround;
            Debug.Log("Est");
        }
        else if (NumberGround == 4)
        {
            Background.sprite = FourGround;
            Debug.Log("Est");
        }
        {
            NumberGround = NumberGround;
        }
        if (NumberGround == 5)
        {
            Background.sprite = FiveGround;
        }
        else if (NumberGround == 6)
        {
            Background.sprite = SixBCG;
        }
        else if (NumberGround == 7)
        {
            Background.sprite = SevenBCG;
        }



        //постоянное обновление кнопки клика
        if (NumberBTN == 1)
        {
            Buttons.sprite = FirstBTN;
            Debug.Log("Est");
        }
        else if (NumberBTN == 2)
        {
            Buttons.sprite = SecondBTN;
            Debug.Log("Est");
        }
        else if (NumberBTN == 3)
        {
            Buttons.sprite = ThirdBTN;
            Debug.Log("Est");
        }
        else if (NumberBTN == 4)
        {
            Buttons.sprite = FourBTN;
            Debug.Log("Est");
        }
        {
            NumberBTN = NumberBTN;
        }
        if (NumberBTN == 5)
        {
            Buttons.sprite = FiveBTN;
            Debug.Log("Est");
        }
        else if (NumberBTN == 6)
        {
            Buttons.sprite = SixBTN;
        }
        else if (NumberBTN == 7)
        {
            Buttons.sprite = SevenBTN;
        }
        else if (NumberBTN == 8)
        {
            Buttons.sprite = EightBTN;
        }
        else if (NumberBTN == 9)
        {
            Buttons.sprite = NineBTN;
        }










        if (Nclick < 10000)
        {
            GradeClicks = ("/" + "10 000");
        }
        else if (Nclick < 100000)
        {
            GradeClicks = ("/" + "100 000");
        }
        else if (Nclick < 1000000)
        {
            GradeClicks = ("/" + "1 000 000");
        }
        else if (Nclick > 1000000)
        {
            GradeClicks = ("");
        }


        if (Rebcount < 2)
        {
            GradeRebs = ("/" + "2");
        }
        else if (Rebcount < 6)
        {
            GradeRebs = ("/" + "6");
        }
        else if (Rebcount < 10)
        {
            GradeRebs = ("/" + "10");
        }
        else if (Rebcount > 10)
        {
            GradeRebs = ("");
        }




        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Shop");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (Language == 0)
            {
                Vector2 newSize = rectTransform.sizeDelta + new Vector2(-20f, 0f);
                rectTransform.sizeDelta = newSize;

                if (button != null)
                {
                    if (NumberGround == 1)
                    {

                        button.image.sprite = ShopButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = ShopSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = ShopJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = ShopWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = ShopMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = ShopMountButton;
                    }
                }
            }
            else if (Language == 1)
            {
                Vector2 newSize = rectTransform.sizeDelta + new Vector2(20f, 0f);
                rectTransform.sizeDelta = newSize;
                if (button != null)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = ShopButtonRus;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = ShopSpaceButtonRus;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = ShopJapanButtonRus;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = ShopWallButtonRus;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = ShopMisteryButtonRus;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = ShopMountButtonRus;
                    }
                }

            }

        }

        objectsWithTag = GameObject.FindGameObjectsWithTag("Background");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(150f, 0f);
                    if (NumberGround == 1)
                    {
                        button.image.sprite = BackgroundsButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = BackgroundsSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = BackgroundsJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = BackgroundsWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = BackgroundsMysteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = BackgroundsMountButton;
                    }
                }
                else if (Language == 1)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(-150f, 0f);
                    rectTransform.sizeDelta = newSize;
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = BackgroundsButtonRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = BackgroundsSpaceButtonRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = BackgroundsJapanButtonRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = BackgroundsWallButtonRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = BackgroundsMysteryButtonRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = BackgroundsMountButtonRus;
                        }
                    }
                }
            }
        }

        objectsWithTag = GameObject.FindGameObjectsWithTag("AboutUs");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(30f, 0f);
                    rectTransform.sizeDelta = newSize;

                    if (Language == 0)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = AboutUsButton;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = AboutUsSpaceButton;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = AboutUsjapanButton;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = AboutUsWallButton;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = AboutUsMisteryButton;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = AboutUsMountButton;
                        }
                    }
                }
                else if (Language == 1)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(-270f, 0f);
                    rectTransform.sizeDelta = newSize;
                    if (NumberGround == 1)
                    {
                        button.image.sprite = AboutUsButtonRus;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = AboutUsSpaceButtonRus;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = AboutUsjapanButtonRus;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = AboutUsWallButtonRus;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = AboutUsMisteryButtonRus;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = AboutUsMountButtonRus;
                    }

                }

            }

        }


        objectsWithTag = GameObject.FindGameObjectsWithTag("BackgroundMenu");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(300f, 0f);
                    if (NumberGround == 1)
                    {
                        button.image.sprite = BackgroundsButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = BackgroundsSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = BackgroundsJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = BackgroundsWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = BackgroundsMysteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = BackgroundsMountButton;
                    }
                }
                else if (Language == 1)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(-300f, 0f);
                    rectTransform.sizeDelta = newSize;
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = BackgroundsButtonRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = BackgroundsSpaceButtonRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = BackgroundsJapanButtonRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = BackgroundsWallButtonRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = BackgroundsMysteryButtonRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = BackgroundsMountButtonRus;
                        }
                    }
                }
            }
        }


        objectsWithTag = GameObject.FindGameObjectsWithTag("Language");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(200f, 0f);
                    if (NumberGround == 1)
                    {
                        button.image.sprite = LanguageB;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = LanguageBSpace;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = LanguageBJapan;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = LanguageBWall;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = LanguageBMistery;
                    }
                    
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = LanguageBMount;
                    }
                }
                else if (Language == 1)
                {
                    Vector2 newSize = rectTransform.sizeDelta + new Vector2(-200f, 0f);
                    rectTransform.sizeDelta = newSize;
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = LanguageBRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = LanguageBSpaceRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = LanguageBJapanRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = LanguageBWallRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = LanguageBMisteryRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = LanguageBMountRus;
                        }
                    }
                }
            }
        }



    }
    public static int NBG;
    public static int NBB;
    // Update is called once per frame
    void Update()
    {

        NBG = NumberGround;
        NBB = NumberBTN;

        if (Language == 0)
        {
            ShopText.text = "Shop";
            PerClickString = "per click";
            RebString = "Rebirth: ";
            MoneyStringShop.text = "Money: ";
            PerClickStringShop.text = "Per click: ";
            Grade1Text.text = "First";
            Grade2Text.text = "Second";
            Grade3Text.text = "Third";
            Grade4Text.text = "Four";
            Grade5Text.text = "Five";
            Grade6Text.text = "Six";
            GradeRebText.text = "Rebirth";
            MenuText.text = "Menu";
            ButtonShopText.text = "Skins for button";
            BackgroundShopText.text = "Skins for background";
            AchievClickText.text = "Click's";
            AchievText.text = "Achievments";
            AchivRebText.text = "Rebirth's";
            LanguageSelect.text = "Language";
            SecretText.text = "?? ??????, ??????? ?/? ????????????.";
            SecretShop.text = "Secret Shop";
        }
        else if (Language == 1)
        {
            ShopText.text = "Магазин";
            PerClickString = "за клик";
            RebString = "Сбросы: ";
            MoneyStringShop.text = "Денег: ";
            PerClickStringShop.text = "За клик: ";
            Grade1Text.text = "Первое";
            Grade2Text.text = "Второе";
            Grade3Text.text = "Третье";
            Grade4Text.text = "Четвёртое";
            Grade5Text.text = "Пятое";
            Grade6Text.text = "Шестое";
            GradeRebText.text = "Сброс";
            MenuText.text = "Меню";
            ButtonShopText.text = "Облики для кнопки";
            BackgroundShopText.text = "Облики для фона";
            AchievClickText.text = "Кликов";
            AchievText.text = "Достижения";
            AchivRebText.text = "Сбросов";
            LanguageSelect.text = "Язык";
            SecretText.text = "????? ???????, ???????? ?/? ??????????.";
            SecretShop.text = "Тайный магазин";
        }
        AllAchievs = NumberClick + NumberReb;
        moneyText.text = money.ToString();
        CMonet.text = Costint.ToString("N").Replace(",00", "");
        CCost.text = CMoney.ToString("N").Replace(",00", "") + " " + PerClickString;
        ShopClick.text = CMoney.ToString("N").Replace(",00", "");
        Reb.text = RebString + Rebcount.ToString();
        
        RebText.text = Rebcost.ToString("N").Replace(",00", "");
        g2t.text = g2.ToString("N").Replace(",00", "");
        g3t.text = g3.ToString("N").Replace(",00", "");
        g4t.text = g4.ToString("N").Replace(",00", "");
        g5t.text = g5.ToString("N").Replace(",00", "");
        g6t.text = g6.ToString("N").Replace(",00", "");
        HowManyClicks.text = Nclick.ToString("N").Replace(",00", "") + GradeClicks;
        HowManyRebs.text = Rebcount.ToString("N").Replace(",00", "") + GradeRebs;
        moneyText.text = string.Format("{0:#,##0.00}", money).Replace(",00", "");
        AchievCount.text = AllAchievs.ToString() + "/6";
        BuyB.sprite = BuyB.sprite;
        BCGSpace.sprite = BCGSpace.sprite;
        BCGJapan.sprite = BCGJapan.sprite;
        BCGWall.sprite = BCGWall.sprite;
        MisteryBCG.sprite = MisteryBCG.sprite;


        if (NumberClick == 1)
        {
            Color cupColor = CupsClick.color;
            cupColor.a = 255f;
            CupsClick.color = cupColor;
            CupsClick.sprite = BronzeClick;
        }
        else if (NumberClick == 2)
        {
            CupsClick.sprite = SilverClick;
        }
        else if (NumberClick == 3)
        {
            CupsClick.sprite = GoldClick;
        }


        if (Nclick >= 10000)
        {
            NumberClick = 1;
        }
        if (Nclick >= 100000)
        {
            NumberClick = 2;
        }
        if (Nclick >= 1000000)
        {
            NumberClick = 3;
        }
        if (Nclick < 10000)
        {
            Color cupColor = CupsClick.color;
            cupColor.a = 0f;
            CupsClick.color = cupColor;
        }




        if (NumberReb == 1)
        {
            Color cupsColor = CupsReb.color;
            cupsColor.a = 255f;
            CupsReb.color = cupsColor;
            CupsReb.sprite = BronzeReb;
        }
        else if (NumberReb == 2)
        {
            CupsReb.sprite = SilverReb;
        }
        else if (NumberReb == 3)
        {
            CupsReb.sprite = GoldReb;
        }


        if (Rebcount >= 2)
        {
            NumberReb = 1;
        }
        if (Rebcount >= 6)
        {
            NumberReb = 2;
        }
        if (Rebcount >= 10)
        {
            NumberReb = 3;
        }
        if (Rebcount < 2)
        {
            Color cupsColor = CupsReb.color;
            cupsColor.a = 0f;
            CupsReb.color = cupsColor;
        }




        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("BuyButton");
        foreach (GameObject obj in objectsWithTag)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            Button button = obj.GetComponent<Button>();
            if (Language == 0)
            {
                if (button != null)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = BuyButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = BuySpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = BuyJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = BuyWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = BuyMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = BuyMountButton;
                    }


                }
            }
            else if (Language == 1)
            {
                if (button != null)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = BuyButtonRus;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = BuySpaceButtonRus;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = BuyJapanButtonRus;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = BuyWallButtonRus;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = BuyMisteryButtonRus;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = BuyMountButtonRus;
                    }
                }

            }


        }
        





        objectsWithTag = GameObject.FindGameObjectsWithTag("Buttons");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = ButtonsButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = ButtonsSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = ButtonsJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = ButtonsWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = ButtonsMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = ButtonsMountButton;
                    }
                }
                else if (Language == 1)
                {
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = ButtonsButtonRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = ButtonsSpaceButtonRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = ButtonsJapanButtonRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = ButtonsWallButtonRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = ButtonsMisteryButtonRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = ButtonsMountButtonRus;
                        }
                    }
                }
            }
        }


        


        objectsWithTag = GameObject.FindGameObjectsWithTag("Menu");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0) { 
                    if (NumberGround == 1)
                    {
                        button.image.sprite = MenuButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = MenuSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = MenuJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = MenuWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = MenuMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = MenuMountButton;
                    }
                }
                else if (Language == 1)
                {
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = MenuButtonRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = MenuSpaceButtonRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = MenuJapanButtonRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = MenuWallButtonRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = MenuMisteryButtonRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = MenuMountButtonRus;
                        }
                    }

                }
            }
        }

        objectsWithTag = GameObject.FindGameObjectsWithTag("Home");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = HomeButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = HomeSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = HomeJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = HomeWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = HomeMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = HomeMountButton;
                    }
             
            }
            
        }

        objectsWithTag = GameObject.FindGameObjectsWithTag("Achievs");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = AchievmentButton;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = AchievmentSpaceButton;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = AchievmentJapanButton;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = AchievmentWallButton;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = AchievmentMisteryButton;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = AchievmentMountButton;
                    }
                }
                else if (Language == 1)
                {
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = AchievmentButtonRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = AchievmentSpaceButtonRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = AchievmentJapanButtonRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = AchievmentWallButtonRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = AchievmentMisteryButtonRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = AchievmentMountButtonRus;
                        }
                    }

                }
            }
        }




        objectsWithTag = GameObject.FindGameObjectsWithTag("Secret");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                if (Language == 0)
                {
                    if (NumberGround == 1)
                    {
                        button.image.sprite = SecretB;
                    }
                    else if (NumberGround == 2)
                    {
                        button.image.sprite = SecretBSpace;
                    }
                    else if (NumberGround == 3)
                    {
                        button.image.sprite = SecretBJapan;
                    }
                    else if (NumberGround == 5)
                    {
                        button.image.sprite = SecretBWall;
                    }
                    else if (NumberGround == 6)
                    {
                        button.image.sprite = SecretBMistery;
                    }
                    else if (NumberGround == 7)
                    {
                        button.image.sprite = SecretBMount;
                    }
                }
                else if (Language == 1)
                {
                    if (button != null)
                    {
                        if (NumberGround == 1)
                        {
                            button.image.sprite = SecretBRus;
                        }
                        else if (NumberGround == 2)
                        {
                            button.image.sprite = SecretBSpaceRus;
                        }
                        else if (NumberGround == 3)
                        {
                            button.image.sprite = SecretBJapanRus;
                        }
                        else if (NumberGround == 5)
                        {
                            button.image.sprite = SecretBWallRus;
                        }
                        else if (NumberGround == 6)
                        {
                            button.image.sprite = SecretBMisteryRus;
                        }
                        else if (NumberGround == 7)
                        {
                            button.image.sprite = SecretBMountRus;
                        }
                    }

                }
            }
        }




        objectsWithTag = GameObject.FindGameObjectsWithTag("RussianLang");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {

                if (NumberGround == 1)
                {
                    button.image.sprite = RussianLang;
                }
                else if (NumberGround == 2)
                {
                    button.image.sprite = RussianSpaceLang;
                }
                else if (NumberGround == 3)
                {
                    button.image.sprite = RussianJapanLang;
                }
                else if (NumberGround == 5)
                {
                    button.image.sprite = RussianWallLang;
                }
                else if (NumberGround == 6)
                {
                    button.image.sprite = RussianMisteryLang;
                }
                else if (NumberGround == 7)
                {
                    button.image.sprite = RussianMountLang;
                }


            }
        }



        objectsWithTag = GameObject.FindGameObjectsWithTag("EnglishLang");
        foreach (GameObject obj in objectsWithTag)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {

                if (NumberGround == 1)
                {
                    button.image.sprite = EnglishLang;
                }
                else if (NumberGround == 2)
                {
                    button.image.sprite = EnglishSpaceLang;
                }
                else if (NumberGround == 3)
                {
                    button.image.sprite = EnglishJapanLang;
                }
                else if (NumberGround == 5)
                {
                    button.image.sprite = EnglishWallLang;
                }
                else if (NumberGround == 6)
                {
                    button.image.sprite = EnglishMisteryLang;
                }
                else if (NumberGround == 7)
                {
                    button.image.sprite = EnglishMountLang;
                }


            }
        }








        if (Rebcount < 0)
        {
            BuyB.sprite = BuyBLock;
        }
        else if (Rebcount >= 0 && NumberGround == 1)
        {
            if (Language == 0) { 
                BCGSpace.sprite = SelectButton;
                BCGJapan.sprite = SelectButton;
                BuyB.sprite = CompleteFirst;
                BCGWall.sprite = SelectButton;
                BuyBKitty.sprite = SelectButton;
                BuyBPlanet.sprite = SelectButton;
                BuyBFlower.sprite = SelectButton;
                BCGStandart.sprite = SelectButton;
                BuyBBird.sprite = SelectButton;
                BuyBSpray.sprite = SelectButton;
                MisteryBCG.sprite = SelectButton;
                MisteryBTN.sprite = SelectButton;
                CBS.BuyBTent.sprite = SelectButton;
                CBS.BuyFinger.sprite = SelectButton;
                BCGMountain.sprite = SelectButton;
            }
            else if (Language == 1)
            {
                BCGSpace.sprite = SelectButtonRus;
                BCGJapan.sprite = SelectButtonRus;
                BuyB.sprite = CompleteFirst;
                BCGWall.sprite = SelectButtonRus;
                BuyBKitty.sprite = SelectButtonRus;
                BuyBPlanet.sprite = SelectButtonRus;
                BuyBFlower.sprite = SelectButtonRus;
                BCGStandart.sprite = SelectButtonRus;
                BuyBBird.sprite = SelectButtonRus;
                BuyBSpray.sprite = SelectButtonRus;
                MisteryBCG.sprite = SelectButtonRus;
                MisteryBTN.sprite = SelectButtonRus;
                CBS.BuyBTent.sprite = SelectButtonRus;
                CBS.BuyFinger.sprite = SelectButtonRus;
                BCGMountain.sprite = SelectButtonRus;
            }
        }

        if (Rebcount < 3)
        {
            BCGSpace.sprite = BuyBLock;
        }
        else if (Rebcount >= 2 && NumberGround == 2)
        {
            if (Language == 0)
            {
                BCGSpace.sprite = CompleteSecond;
                BCGJapan.sprite = SelectSpaceButton;
                BuyB.sprite = SelectSpaceButton;
                BCGWall.sprite = SelectSpaceButton;
                BuyBKitty.sprite = SelectSpaceButton;
                BuyBPlanet.sprite = SelectSpaceButton;
                BuyBFlower.sprite = SelectSpaceButton;
                BCGStandart.sprite = SelectSpaceButton;
                BuyBBird.sprite = SelectSpaceButton;
                BuyBSpray.sprite = SelectSpaceButton;
                MisteryBCG.sprite = SelectSpaceButton;
                MisteryBTN.sprite = SelectSpaceButton;
                CBS.BuyBTent.sprite = SelectSpaceButton;
                CBS.BuyFinger.sprite = SelectSpaceButton;
                BCGMountain.sprite = SelectSpaceButton;
            }
            else if (Language == 1)
            {
                BCGSpace.sprite = CompleteSecond;
                BCGJapan.sprite = SelectSpaceButtonRus;
                BuyB.sprite = SelectSpaceButtonRus;
                BCGWall.sprite = SelectSpaceButtonRus;
                BuyBKitty.sprite = SelectSpaceButtonRus;
                BuyBPlanet.sprite = SelectSpaceButtonRus;
                BuyBFlower.sprite = SelectSpaceButtonRus;
                BCGStandart.sprite = SelectSpaceButtonRus;
                BuyBBird.sprite = SelectSpaceButtonRus;
                BuyBSpray.sprite = SelectSpaceButtonRus;
                MisteryBCG.sprite = SelectSpaceButtonRus;
                MisteryBTN.sprite = SelectSpaceButtonRus;
                CBS.BuyBTent.sprite = SelectSpaceButtonRus;
                CBS.BuyFinger.sprite = SelectSpaceButtonRus;
                BCGMountain.sprite = SelectSpaceButtonRus;
            }
        }

        if (Nclick < 55000)
        {
            BCGSpace.sprite = BuyBLock;
        }
        else if (Nclick >= 55000 && NumberGround == 7)
        {
            if (Language == 0)
            {
                BCGSpace.sprite = SelectMountButton;
                BCGJapan.sprite = SelectMountButton;
                BuyB.sprite = SelectMountButton;
                BCGWall.sprite = SelectMountButton;
                BuyBKitty.sprite = SelectMountButton;
                BuyBPlanet.sprite = SelectMountButton;
                BuyBFlower.sprite = SelectMountButton;
                BCGStandart.sprite = SelectMountButton;
                BuyBBird.sprite = SelectMountButton;
                BuyBSpray.sprite = SelectMountButton;
                MisteryBCG.sprite = SelectMountButton;
                MisteryBTN.sprite = SelectMountButton;
                CBS.BuyBTent.sprite = SelectMountButton;
                CBS.BuyFinger.sprite = SelectMountButton;
                BCGMountain.sprite = CompleteFive;
            }
            else if (Language == 1)
            {
                BCGSpace.sprite = SelectMountButtonRus;
                BCGJapan.sprite = SelectMountButtonRus;
                BuyB.sprite = SelectMountButtonRus;
                BCGWall.sprite = SelectMountButtonRus;
                BuyBKitty.sprite = SelectMountButtonRus;
                BuyBPlanet.sprite = SelectMountButtonRus;
                BuyBFlower.sprite = SelectMountButtonRus;
                BCGStandart.sprite = SelectMountButtonRus;
                BuyBBird.sprite = SelectMountButtonRus;
                BuyBSpray.sprite = SelectMountButtonRus;
                MisteryBCG.sprite = SelectMountButtonRus;
                MisteryBTN.sprite = SelectMountButtonRus;
                CBS.BuyBTent.sprite = SelectMountButtonRus;
                CBS.BuyFinger.sprite = SelectMountButtonRus;
                BCGMountain.sprite = CompleteFive;
            }
        }



        if (Rebcount < 6)
        {
            BCGWall.sprite = BuyBLock;
        }
        else if (Rebcount >= 3 && NumberGround == 5)
        {
            if (Language == 0)
            {
                BCGSpace.sprite = SelectWallButton;
                BCGJapan.sprite = SelectWallButton;
                BuyB.sprite = SelectWallButton;
                BCGWall.sprite = CompleteThird;
                BuyBKitty.sprite = SelectWallButton;
                BuyBPlanet.sprite = SelectWallButton;
                BuyBFlower.sprite = SelectWallButton;
                BCGStandart.sprite = SelectWallButton;
                BuyBBird.sprite = SelectWallButton;
                BuyBSpray.sprite = SelectWallButton;
                MisteryBCG.sprite = SelectWallButton;
                MisteryBTN.sprite = SelectWallButton;
                CBS.BuyBTent.sprite = SelectWallButton;
                CBS.BuyFinger.sprite = SelectWallButton;
                BCGMountain.sprite = SelectWallButton;
            }
            else if (Language == 1)
            {
                BCGSpace.sprite = SelectWallButtonRus;
                BCGJapan.sprite = SelectWallButtonRus;
                BuyB.sprite = SelectWallButtonRus;
                BCGWall.sprite = CompleteThird;
                BuyBKitty.sprite = SelectWallButtonRus;
                BuyBPlanet.sprite = SelectWallButtonRus;
                BuyBFlower.sprite = SelectWallButtonRus;
                BCGStandart.sprite = SelectWallButtonRus;
                BuyBBird.sprite = SelectWallButtonRus;
                BuyBSpray.sprite = SelectWallButtonRus;
                MisteryBCG.sprite = SelectWallButtonRus;
                MisteryBTN.sprite = SelectWallButtonRus;
                CBS.BuyBTent.sprite = SelectWallButtonRus;
                CBS.BuyFinger.sprite = SelectWallButtonRus;
                BCGMountain.sprite = SelectWallButtonRus;
            }
        }
        if (AllAchievs == 6 && NumberGround == 6)
        {
            if (Language == 0)
            {
                BCGSpace.sprite = SelectMisteryButton;
                BCGJapan.sprite = SelectMisteryButton;
                BuyB.sprite = SelectMisteryButton;
                BCGWall.sprite = SelectMisteryButton;
                BuyBKitty.sprite = SelectMisteryButton;
                BuyBPlanet.sprite = SelectMisteryButton;
                BuyBFlower.sprite = SelectMisteryButton;
                BCGStandart.sprite = SelectMisteryButton;
                BuyBBird.sprite = SelectMisteryButton;
                BuyBSpray.sprite = SelectMisteryButton;
                MisteryBCG.sprite = CompleteSix;
                MisteryBTN.sprite = SelectMisteryButton;
                CBS.BuyBTent.sprite = SelectMisteryButton;
                CBS.BuyFinger.sprite = SelectMisteryButton;
                BCGMountain.sprite = SelectMisteryButton;
            }
            else if (Language == 1)
            {
                BCGSpace.sprite = SelectMisteryButtonRus;
                BCGJapan.sprite = SelectMisteryButtonRus;
                BuyB.sprite = SelectMisteryButtonRus;
                BCGWall.sprite = SelectMisteryButtonRus;
                BuyBKitty.sprite = SelectMisteryButtonRus;
                BuyBPlanet.sprite = SelectMisteryButtonRus;
                BuyBFlower.sprite = SelectMisteryButtonRus;
                BCGStandart.sprite = SelectMisteryButtonRus;
                BuyBBird.sprite = SelectMisteryButtonRus;
                BuyBSpray.sprite = SelectMisteryButtonRus;
                MisteryBCG.sprite = CompleteSix;
                MisteryBTN.sprite = SelectMisteryButtonRus;
                CBS.BuyBTent.sprite = SelectMisteryButtonRus;
                CBS.BuyFinger.sprite = SelectMisteryButtonRus;
                BCGMountain.sprite = SelectMisteryButtonRus;
            }
        }














        if (Rebcount < 0)
        {
            BCGMisteryBCG.sprite = BuyBLock;
        }

        if (Rebcount < 10)
        {
            BuyBKitty.sprite = BuyBLock;
        }

        if (Rebcount < 4)
        {
            BuyBPlanet.sprite = BuyBLock;
        }

        if (Rebcount < 8)
        {
            BuyBFlower.sprite = BuyBLock;
        }

        if (Rebcount < 0)
        {
            BCGStandart.sprite = BuyBLock;
        }

        if (Rebcount < 1)
        {
            BuyBBird.sprite = BuyBLock;
        }

        if (Rebcount < 6)
        {
            BCGWall.sprite = BuyBLock;
        }

        if (Rebcount < 7)
        {
            BuyBSpray.sprite = BuyBLock;
        }


        if (Rebcount < 9)
        {
            BCGJapan.sprite = BuyBLock;
        }
        else if (Rebcount >= 5 && NumberGround == 3)
        {
            if (Language == 0)
            {
                BCGSpace.sprite = SelectJapanButton;
                BCGJapan.sprite = CompleteFour;
                BuyB.sprite = SelectJapanButton;
                BuyBKitty.sprite = SelectJapanButton;
                BCGWall.sprite = SelectJapanButton;
                BuyBPlanet.sprite = SelectJapanButton;
                BuyBFlower.sprite = SelectJapanButton;
                BCGStandart.sprite = SelectJapanButton;
                BuyBBird.sprite = SelectJapanButton;
                BuyBSpray.sprite = SelectJapanButton;
                MisteryBCG.sprite = SelectJapanButton;
                MisteryBTN.sprite = SelectJapanButton;
                CBS.BuyBTent.sprite = SelectJapanButton;
                CBS.BuyFinger.sprite = SelectJapanButton;
                BCGMountain.sprite = SelectJapanButton;


            }
            else if (Language == 1)
            {
                BCGSpace.sprite = SelectJapanButtonRus;
                BCGJapan.sprite = CompleteFour;
                BuyB.sprite = SelectJapanButtonRus;
                BuyBKitty.sprite = SelectJapanButtonRus;
                BCGWall.sprite = SelectJapanButtonRus;
                BuyBPlanet.sprite = SelectJapanButtonRus;
                BuyBFlower.sprite = SelectJapanButtonRus;
                BCGStandart.sprite = SelectJapanButtonRus;
                BuyBBird.sprite = SelectJapanButtonRus;
                BuyBSpray.sprite = SelectJapanButtonRus;
                MisteryBCG.sprite = SelectJapanButtonRus;
                MisteryBTN.sprite = SelectJapanButtonRus;
                CBS.BuyBTent.sprite = SelectJapanButtonRus;
                CBS.BuyFinger.sprite = SelectJapanButtonRus;
                BCGMountain.sprite = SelectJapanButtonRus;
            }
        }

        if (NumberBTN == 1 && NumberGround == 1)
        {
            BuyBKitty.sprite = CompleteFirst;
        }
        else if (NumberBTN == 1 && NumberGround == 2)
        {
            BuyBKitty.sprite = CompleteSecond;
        }
        else if (NumberBTN == 1 && NumberGround == 5)
        {
            BuyBKitty.sprite = CompleteThird;
        }
        else if (NumberBTN == 1 && NumberGround == 3)
        {
            BuyBKitty.sprite = CompleteFour;
        }
        else if (NumberBTN == 1 && NumberGround == 7)
        {
            BuyBKitty.sprite = CompleteFive;
        }
        else if (NumberBTN == 1 && NumberGround == 6)
        {
            BuyBKitty.sprite = CompleteSix;
        }



        if (NumberBTN == 4 && NumberGround == 1)
        {
            BCGStandart.sprite = CompleteFirst;
        }
        else if (NumberBTN == 4 && NumberGround == 2)
        {
            BCGStandart.sprite = CompleteSecond;
        }
        else if (NumberBTN == 4 && NumberGround == 5)
        {
            BCGStandart.sprite = CompleteThird;
        }
        else if (NumberBTN == 4 && NumberGround == 3)
        {
            BCGStandart.sprite = CompleteFour;
        }
        else if (NumberBTN == 4 && NumberGround == 7)
        {
            BCGStandart.sprite = CompleteFive;
        }
        else if (NumberBTN == 4 && NumberGround == 6)
        {
            BCGStandart.sprite = CompleteSix;
        }




        if (NumberBTN == 2 && NumberGround == 1)
        {
            BuyBPlanet.sprite = CompleteFirst;
        }
        else if (NumberBTN == 2 && NumberGround == 2)
        {
            BuyBPlanet.sprite = CompleteSecond;
        }
        else if (NumberBTN == 2 && NumberGround == 5)
        {
            BuyBPlanet.sprite = CompleteThird;
        }
        else if (NumberBTN == 2 && NumberGround == 3)
        {
            BuyBPlanet.sprite = CompleteFour;
        }
        else if (NumberBTN == 2 && NumberGround == 7)
        {
            BuyBPlanet.sprite = CompleteFive;
        }
        else if (NumberBTN == 2 && NumberGround == 6)
        {
            BuyBPlanet.sprite = CompleteSix;
        }


        if (NumberBTN == 6 && NumberGround == 1)
        {
            BuyBSpray.sprite = CompleteFirst;
        }
        else if (NumberBTN == 6 && NumberGround == 2)
        {
            BuyBSpray.sprite = CompleteSecond;
        }
        else if (NumberBTN == 6 && NumberGround == 5)
        {
            BuyBSpray.sprite = CompleteThird;
        }
        else if (NumberBTN == 6 && NumberGround == 3)
        {
            BuyBSpray.sprite = CompleteFour;
        }
        else if (NumberBTN == 6 && NumberGround == 7)
        {
            BuyBSpray.sprite = CompleteFive;
        }
        else if (NumberBTN == 6 && NumberGround == 6)
        {
            BuyBSpray.sprite = CompleteSix;
        }



        if (NumberBTN == 3 && NumberGround == 1)
        {
            BuyBFlower.sprite = CompleteFirst;
        }
        else if (NumberBTN == 3 && NumberGround == 2)
        {
            BuyBFlower.sprite = CompleteSecond;
        }
        else if (NumberBTN == 3 && NumberGround == 5)
        {
            BuyBFlower.sprite = CompleteThird;
        }
        else if (NumberBTN == 3 && NumberGround == 3)
        {
            BuyBFlower.sprite = CompleteFour;
        }
        else if (NumberBTN == 3 && NumberGround == 7)
        {
            BuyBFlower.sprite = CompleteFive;
        }
        else if (NumberBTN == 3 && NumberGround == 6)
        {
            BuyBFlower.sprite = CompleteSix;
        }


        if (NumberBTN == 8 && NumberGround == 1)
        {
            CBS.BuyFinger.sprite = CompleteFirst;
        }
        else if (NumberBTN == 8 && NumberGround == 2)
        {
            CBS.BuyFinger.sprite = CompleteSecond;
        }
        else if (NumberBTN == 8 && NumberGround == 5)
        {
            CBS.BuyFinger.sprite = CompleteThird;
        }
        else if (NumberBTN == 8 && NumberGround == 3)
        {
            CBS.BuyFinger.sprite = CompleteFour;
        }
        else if (NumberBTN == 8 && NumberGround == 7)
        {
            CBS.BuyFinger.sprite = CompleteFive;
        }
        else if (NumberBTN == 8 && NumberGround == 6)
        {
            CBS.BuyFinger.sprite = CompleteSix;
        }


        if (NumberBTN == 9 && NumberGround == 1)
        {
            CBS.BuyBTent.sprite = CompleteFirst;
        }
        else if (NumberBTN == 9 && NumberGround == 2)
        {
            CBS.BuyBTent.sprite = CompleteSecond;
        }
        else if (NumberBTN == 9 && NumberGround == 5)
        {
            CBS.BuyBTent.sprite = CompleteThird;
        }
        else if (NumberBTN == 9 && NumberGround == 3)
        {
            CBS.BuyBTent.sprite = CompleteFour;
        }
        else if (NumberBTN == 9 && NumberGround == 7)
        {
            CBS.BuyBTent.sprite = CompleteFive;
        }
        else if (NumberBTN == 9 && NumberGround == 6)
        {
            CBS.BuyBTent.sprite = CompleteSix;
        }


        if (NumberBTN == 5 && NumberGround == 1)
        {
            BuyBBird.sprite = CompleteFirst;
        }
        else if (NumberBTN == 5 && NumberGround == 2)
        {
            BuyBBird.sprite = CompleteSecond;
        }
        else if (NumberBTN == 5 && NumberGround == 5)
        {
            BuyBBird.sprite = CompleteThird;
        }
        else if (NumberBTN == 5 && NumberGround == 3)
        {
            BuyBBird.sprite = CompleteFour;
        }
        else if (NumberBTN == 5 && NumberGround == 7)
        {
            BuyBBird.sprite = CompleteFive;
        }
        else if (NumberBTN == 5 && NumberGround == 6)
        {
            BuyBBird.sprite = CompleteSix;
        }


        if (NumberBTN == 7 && NumberGround == 1)
        {
            MisteryBTN.sprite = CompleteFirst;
        }
        else if (NumberBTN == 7 && NumberGround == 2)
        {
            MisteryBTN.sprite = CompleteSecond;
        }
        else if (NumberBTN == 7 && NumberGround == 5)
        {
            MisteryBTN.sprite = CompleteThird;
        }
        else if (NumberBTN == 7 && NumberGround == 3)
        {
            MisteryBTN.sprite = CompleteFour;
        }
        else if (NumberBTN == 7 && NumberGround == 7)
        {
            MisteryBTN.sprite = CompleteFive;
        }
        else if (NumberBTN == 7 && NumberGround == 6)
        {
            MisteryBTN.sprite = CompleteSix;
        }






    }
    public void SelectLanguage()
    {
        SceneManager.LoadScene(6);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);

    }

    public void AVFarm()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);

    }


    public void Home()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);
    }

    public void Skins()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);
    }
    public void Skins_buttons()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);
    }

    public void Menu()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);
    }

    public void Achievs()
    {
        SceneManager.LoadScene(5);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Rebcount", Rebcount);
        PlayerPrefs.SetInt("CMoney", CMoney);
        PlayerPrefs.SetInt("Costint", Costint);
        PlayerPrefs.SetInt("g2", g2);
        PlayerPrefs.SetInt("g3", g3);
        PlayerPrefs.SetInt("g4", g4);
        PlayerPrefs.SetInt("g5", g5);
        PlayerPrefs.SetInt("g6", g6);
        PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        PlayerPrefs.SetInt("NumberGround", NumberGround);
        PlayerPrefs.SetInt("Nclick", Nclick);
        PlayerPrefs.SetInt("Language", Language);
    }


    public void BuyClick()
    {
        if (money>= Costint)
        {
            money -= Costint;
            Costint *= 2;
            CMoney += 20;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Nclick", Nclick);
            PlayerPrefs.SetInt("Language", Language);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }

    }

    public void RebBuy()
    {
        if (money >= Rebcost)
        {
            money -= money;
            g2 -= g2 - 1000;
            g3 -= g3 -100000;
            g4 -= g4 -1000000;
            g5 -= g5 -2000000;
            g6 -= g6 - 20000000;
            Costint -= Costint - 10;
            CMoney -= CMoney - 1;
            Rebcount += 1;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Nclick", Nclick);
            PlayerPrefs.SetInt("Language", Language);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }


    }
/* auto-farm(NOT valiable)
    public void MTim()
    {
        if (money >= 1000)
        {
            money -= 1000;
            CGrowMT *= 1.5;
            GrowMT -= 500;

        }
        
    }


    public void MMon()
    {
        if (money >= 1000)
        {
            money -= 1000;
            CGrowMM *= 2;
            GrowMM += 1;
        }
        while (!this.IsDisposed) {
            Thread.Sleep(GrowMT);
            
        }
 */
    public void Fgrad()
    {
        if (money >= g2)
        {
            money -= g2;
            g2 *= 2;
            CMoney += 200;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("Nclick", Nclick);
            

        }

    }

    public void Sgrad()
    {
        if (money >= g3)
        {
            money -= g3;
            g3 *= 2;
            CMoney += 500;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("Nclick", Nclick);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }

    }

    public void Thgrad()
    {
        if (money >= g4)
        {
            money -= g4;
            g4 *= 2;
            CMoney += 1000;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("Nclick", Nclick);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }

    }

    public void Fougrad()
    {
        if (money >= g5)
        {
            money -= g5;
            g5 *= 2;
            CMoney += 5000;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("Nclick", Nclick);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }

    }

    public void Fivegrad()
    {
        if (money >= g6)
        {
            money -= g6;
            g6 *= 2;
            CMoney += 15000;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("Rebcount", Rebcount);
            PlayerPrefs.SetInt("CMoney", CMoney);
            PlayerPrefs.SetInt("g2", g2);
            PlayerPrefs.SetInt("g3", g3);
            PlayerPrefs.SetInt("g4", g4);
            PlayerPrefs.SetInt("g5", g5);
            PlayerPrefs.SetInt("g6", g6);
            PlayerPrefs.SetInt("Costint", Costint);
            PlayerPrefs.SetInt("Nclick", Nclick);
            if (RCount >= 10 && RCount <= 20 && Language == 1)
            {
                SceneManager.LoadScene(8);
            }
            else if (RCount >= 10 && RCount <= 20 && Language == 0)
            {
                SceneManager.LoadScene(9);
            }

            if (RCount >= 21 && RCount <= 31 && Language == 1)
            {
                SceneManager.LoadScene(10);
            }
            else if (RCount >= 21 && RCount <= 31 && Language == 0)
            {
                SceneManager.LoadScene(11);
            }

            if (RCount >= 32 && RCount <= 42 && Language == 1)
            {
                SceneManager.LoadScene(12);
            }
            else if (RCount >= 32 && RCount <= 42 && Language == 0)
            {
                SceneManager.LoadScene(13);
            }
        }

    }

    public void ChangeOnFirstBack()
    {
        if (Rebcount >= 0) {
            BuyB.sprite = BuyB.sprite;
            currentSprite = FirstGround;
            Background.sprite = currentSprite;
            NumberGround = 1;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BuyB.sprite = BuyBLock;
        }
    }

    public void ChangeOnSecondBack()
    {
        if (Rebcount >= 3)
        {
            BCGSpace.sprite = BCGSpace.sprite;
            currentSprite = SecondGround;
            Background.sprite = currentSprite;
            NumberGround = 2;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BCGSpace.sprite = BuyBLock;
        }
    }

    public void ChangeOnThirdBack()
    {
        if (Rebcount >= 9)
        {
            BCGJapan.sprite = BCGJapan.sprite;
            currentSprite = ThirdGround;
            Background.sprite = currentSprite;
            NumberGround = 3;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BCGJapan.sprite = BuyBLock;
        }
    }

    public void ChangeOnFourBack()
    {
        if (Rebcount >= 0)
        {
            BCGMisteryBCG.sprite = BCGMisteryBCG.sprite;
            currentSprite = FourGround;
            Background.sprite = currentSprite;
            NumberGround = 4;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BCGMisteryBCG.sprite = BuyBLock;
        }
    }

    public void ChangeOnfiveBack()
    {
        if (Rebcount >= 6)
        {
            BCGWall.sprite = BCGWall.sprite;
            currentSprite = FiveGround;
            Background.sprite = currentSprite;
            NumberGround = 5;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BCGMisteryBCG.sprite = BuyBLock;
        }
    }

    public void ChangeOnSevenBack()
    {
        if (Nclick >= 55000)
        {
            BCGMountain.sprite = BCGMountain.sprite;
            currentSprite = SevenBCG;
            Background.sprite = currentSprite;
            NumberGround = 7;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
        else
        {
            BCGMountain.sprite = BuyBLock;
        }
    }



    public void ChangeOnSecretBCG()
    {
        if (AllAchievs == 6)
        {
            MisteryBCG.sprite = MisteryBCG.sprite;
            currentSprite = SixBCG;
            Background.sprite = currentSprite;
            NumberGround = 6;
            PlayerPrefs.SetInt("NumberGround", NumberGround);
        }
    }


    public void ChangeOnSecretBTN()
    {
        if (AllAchievs == 6)
        {
            MisteryBTN.sprite = MisteryBTN.sprite;
            currentSprite = SevenBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 7;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
    }

    public void ChangeOnEightBTN()
    {
        if (Nclick >= 5000)
        {
            CBS.BuyFinger.sprite = CBS.BuyFinger.sprite;
            currentButtonSprite = EightBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 8;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
    }

    public void ChangeOnNineBTN()
    {
        if (Nclick >= 55000)
        {
            CBS.BuyBTent.sprite = CBS.BuyBTent.sprite;
            currentButtonSprite = NineBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 9;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
    }





    public void ChangeOnFirstBTN()
    {
        if (Rebcount >= 10)
        {
            BuyBKitty.sprite = BuyBKitty.sprite;
            currentButtonSprite = FirstBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 1;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BuyBKitty.sprite = BuyBLock;
            
        }
    }

    public void ChangeOnSecondBTN()
    {
        if (Rebcount >= 4)
        {
            BuyBPlanet.sprite = BuyBPlanet.sprite;
            currentButtonSprite = SecondBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 2;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BuyBPlanet.sprite = BuyBLock;
        }
    }

    public void ChangeOnThirdBTN()
    {
        if (Rebcount >= 8)
        {
            BuyBFlower.sprite = BuyBFlower.sprite;
            currentButtonSprite = ThirdBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 3;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BuyBFlower.sprite = BuyBLock;
        }
    }

    public void ChangeOnFourBTN()
    {
        if (Rebcount >= 0)
        {
            BCGStandart.sprite = BCGStandart.sprite;
            currentButtonSprite = FourBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 4;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BCGStandart.sprite = BuyBLock;
        }
    }

    public void ChangeOnFiveBTN()
    {
        if (Rebcount >= 1)
        {
            BuyBBird.sprite = BuyBBird.sprite;
            currentButtonSprite = FiveBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 5;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BCGStandart.sprite = BuyBLock;
        }
    }

    public void ChangeOnSixBTN()
    {
        if (Rebcount >= 7)
        {
            BuyBSpray.sprite = BuyBSpray.sprite;
            currentButtonSprite = SixBTN;
            Buttons.sprite = currentButtonSprite;
            NumberBTN = 6;
            PlayerPrefs.SetInt("NumberBTN", NumberBTN);
        }
        else
        {
            BCGStandart.sprite = BuyBLock;
        }
    }


    /* замена тысяч, миллионов и т.д. на буквы
    public string ConvertValue(int money)
    {
        string convertValue;
        if (money >= 1000000000) convertValue = (1f * money / 1000000000).ToString("0.00") + "B";
        else if (money >= 1000000) convertValue = (1f * money / 1000000).ToString("0.00") + "M";
        else if (money >= 1000) convertValue = (1f * money / 1000).ToString("0.00") + "K";
        else convertValue = money.ToString();
        return convertValue;

    
    }


    */

    /*public void Close()
    {
        skin.gameObject.SetActive(false);

    }
    */
}
   



   


    

  
