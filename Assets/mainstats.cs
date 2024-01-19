using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainstats : MonoBehaviour
{

    public int statHappiness;
    public int statMoney;
    public int statmain;
    public SpriteRenderer SRHappy;
    public SpriteRenderer SRMoney;
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

    public SpriteRenderer SRMain;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (statmain >= 90)
        {
            SRMain.sprite = Riko10;
        }
        if (statmain <= 89 && statmain >= 80)
        {
            SRMain.sprite = Riko9;
        }
        if (statmain <= 79 && statmain >= 70)
        {
            SRMain.sprite = Riko8;
        }
        if (statmain <= 69 && statmain >= 60)
        {
            SRMain.sprite = Riko7;
        }
        if (statmain <= 59 && statmain >= 50)
        {
            SRMain.sprite = Riko6;
        }
        if (statmain <= 49 && statmain >= 40)
        {
            SRMain.sprite = Riko5;
        }
        if (statmain <= 39 && statmain >= 30)
        {
            SRMain.sprite = Riko4;
        }
        if (statmain <= 29 && statmain >= 20)
        {
            SRMain.sprite = Riko3;
        }
        if (statmain <= 19 && statmain >= 10)
        {
            SRMain.sprite = Riko2;
        }
        if (statmain <= 9 && statmain >= 0)
        {
            SRMain.sprite = Riko1;
        }
    }
}
