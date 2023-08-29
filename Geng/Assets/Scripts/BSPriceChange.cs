using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSPriceChange : MonoBehaviour
{
    public Main MainScript;
    public Text FirstButton;
    public Text SecondButton;
    public Text ThirdButton;
    public Text FourButton;
    public Text FiveButton;
    public Text SixButton;
    public Text SevenButton;
    public Text EightButton;
    public Image BuyFinger;
    public Image BuyBTent;
    public Text FirstBack;
    public Text SecondBack;
    public Text ThirdBack;
    public Text FourBack;
    public Text FiveBack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainScript.Language == 0)
        {
            FirstButton.text = "0 Reb";
            SecondButton.text = "1 Reb";
            ThirdButton.text = "4 Reb";
            FourButton.text = "7 Reb";
            FiveButton.text = "8 Reb";
            SixButton.text = "10 Reb";
            SevenButton.text = "5 000 Cl";
            EightButton.text = "60 000 Cl";


        }

        if (MainScript.Language == 1)
        {
            FirstButton.text = "0 Ñáð";
            SecondButton.text = "1 Ñáð";
            ThirdButton.text = "4 Ñáð";
            FourButton.text = "7 Ñáð";
            FiveButton.text = "8 Ñáð";
            SixButton.text = "10 Ñáð";
            SevenButton.text = "5 000 Êë";
            EightButton.text = "60 000 Êë";
            FirstBack.text = "0 Ñáð";
            SecondBack.text = "3 Ñáð";
            ThirdBack.text = "6 Ñáð";
            FourBack.text = "9 Ñáð";
            FiveBack.text = "55 000 Êë";
        }
        if (MainScript.Language == 0)
        {
            FirstBack.text = "0 Reb";
            SecondBack.text = "3 Reb";
            ThirdBack.text = "6 Reb";
            FourBack.text = "9 Reb";
            FiveBack.text = "55 000 Cl";
        }
        if (MainScript.Language == 1)
        {
            FirstBack.text = "0 Ñáð";
            SecondBack.text = "3 Ñáð";
            ThirdBack.text = "6 Ñáð";
            FourBack.text = "9 Ñáð";
            FiveBack.text = "55 000 Êë";
        }
    }

}
