using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stats : MonoBehaviour
{
    public int statHappiness;
    public int statMoney;
    public int statmain;
    public SpriteRenderer SRHappy;
    public SpriteRenderer SRMoney;
    public SpriteRenderer SRMain;
    public Sprite Gojo1;
    public Sprite Gojo2;
    public Sprite Gojo3;
    public Sprite Gojo4;
    public Sprite Gojo5;
    public Sprite Gojo6;
    public Sprite Gojo7;
    public Sprite Gojo8;
    public Sprite Gojo9;
    public Sprite Gojo10;

    public Sprite Gojo11;
    public Sprite Geto1;
    public Sprite Geto2;
    public Sprite Geto3;
    public Sprite Geto4;
    public Sprite Geto5;
    public Sprite Geto6;
    public Sprite Geto7;
    public Sprite Geto8;
    public Sprite Geto9;
    public Sprite Geto10;
    public Sprite Geto11;

    public Sprite Riko1;
    public Sprite Riko2;
    public Sprite Riko3;
    public Sprite Riko4;
    public Sprite Riko5;
    public Sprite Riko6;
    public Sprite Riko7;
    public Sprite Riko8;
    public Sprite Riko9;
    public Sprite Riko10;
    public Sprite Riko11;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        


        if (statHappiness >= 90)
        {
            SRHappy.sprite = Gojo11;
        }

        if (statHappiness <= 89 && statHappiness >= 80)
        {
            SRHappy.sprite = Gojo10;
        }

        if (statHappiness <= 79 && statHappiness >= 70)
        {
            SRHappy.sprite = Gojo9;
        }

        if (statHappiness <= 69 && statHappiness >= 60)
        {
            SRHappy.sprite = Gojo8;
        }

        if (statHappiness <= 59 && statHappiness >= 50)
        {
            SRHappy.sprite = Gojo7;
        }

        if (statHappiness <= 49 && statHappiness >= 40)
        {
            SRHappy.sprite = Gojo6;
        }

        if (statHappiness <= 39 && statHappiness >= 30)
        {
            SRHappy.sprite = Gojo5;
        }

        if (statHappiness <= 29 && statHappiness >= 20)
        {
            SRHappy.sprite = Gojo4;
        }

        if (statHappiness <= 19 && statHappiness >= 15)
        {
            SRHappy.sprite = Gojo3;
        }

        if (statHappiness <= 14 && statHappiness >= 10)
        {
            SRHappy.sprite = Gojo2;
        }

        if (statHappiness <= 9 && statHappiness >= 0)
        {
            print("test");
            SRHappy.sprite = Gojo1;
        }

        if (statMoney >= 90)
        {
            SRMoney.sprite = Geto11;
        }
        if (statMoney <= 89 && statMoney >= 80)
        {
            SRMoney.sprite = Geto10;
        }
        if (statMoney <= 79 && statMoney >= 70)
        {
            SRMoney.sprite = Geto9;
        }
        if (statMoney <= 69 && statMoney >= 60)
        {
            SRMoney.sprite = Geto8;
        }
        if (statMoney <= 59 && statMoney >= 50)
        {
            SRMoney.sprite = Geto7;
        }
        if (statMoney <= 49 && statMoney >= 40)
        {
            SRMoney.sprite = Geto6;
        }
        if (statMoney <= 39 && statMoney >= 30)
        {
            SRMoney.sprite = Geto5;
        }
        if (statMoney <= 29 && statMoney >= 20)
        {
            SRMoney.sprite = Geto4;
        }
        if (statMoney <= 19 && statMoney >= 15)
        {
            SRMoney.sprite = Geto3;
        }
        if (statMoney <= 14 && statMoney >= 10)
        {
            SRMoney.sprite = Geto2;
        }
        if (statMoney <= 9 && statMoney >= 0)
        {
            SRMoney.sprite = Geto1;
        }
       if (statmain >= 90)
        {
            SRMain.sprite = Riko11;
        }
        if (statmain >= 89 && statmain >= 80)
        {
            SRMain.sprite = Riko10;
        }
        if (statmain <= 79 && statmain >= 70)
        {
            SRMain.sprite = Riko9;
        }
        if (statmain <= 69 && statmain >= 60)
        {
            SRMain.sprite = Riko8;
        }
        if (statmain <= 59 && statmain >= 50)
        {
            SRMain.sprite = Riko7;
        }
        if (statmain <= 49 && statmain >= 40)
        {
            SRMain.sprite = Riko6;
        }
        if (statmain <= 39 && statmain >= 30)
        {
            SRMain.sprite = Riko5;
        }
        if (statmain <= 29 && statmain >= 20)
        {
            SRMain.sprite = Riko4;
        }   
        if (statmain <= 19 && statmain >= 15)
        {
            SRMain.sprite = Riko3;
        }
        if (statmain <= 14 && statmain >= 10)
        {
            SRMain.sprite = Riko2;
        }
        if (statmain <= 9 && statmain >= 0)
        {
            SRMain.sprite = Riko1;
        }
    
    }
}
           