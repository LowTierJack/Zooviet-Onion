using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class statstuff : MonoBehaviour
{

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

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness >= 90)
        {
            SRHappy.sprite = Gojo11;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 89 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 80)
        {
            SRHappy.sprite = Gojo10;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 79 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 70)
        {
            SRHappy.sprite = Gojo9;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 69 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 60)
        {
            SRHappy.sprite = Gojo8;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 59 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 50)
        {
            SRHappy.sprite = Gojo7;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 49 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 40)
        {
            SRHappy.sprite = Gojo6;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 39 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 30)
        {
            SRHappy.sprite = Gojo5;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 29 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 20)
        {
            SRHappy.sprite = Gojo4;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 19 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 15)
        {
            SRHappy.sprite = Gojo3;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 14 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 10)
        {
            SRHappy.sprite = Gojo2;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statHappiness <= 9 && GameObject.Find("window").GetComponent<Stats>().statHappiness >= 0)
        {
            print("test");
            SceneManager.LoadScene(sceneName: "bad ending");
            SRHappy.sprite = Gojo1;
        }

        if (GameObject.Find("window").GetComponent<Stats>().statMoney >= 90)
        {
            SRMoney.sprite = Geto11;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 89 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 80)
        {
            SRMoney.sprite = Geto10;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 79 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 70)
        {
            SRMoney.sprite = Geto9;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 69 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 60)
        {
            SRMoney.sprite = Geto8;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 59 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 50)
        {
            SRMoney.sprite = Geto7;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 49 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 40)
        {
            SRMoney.sprite = Geto6;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 39 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 30)
        {
            SRMoney.sprite = Geto5;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 29 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 20)
        {
            SRMoney.sprite = Geto4;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 19 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 15)
        {
            SRMoney.sprite = Geto3;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 14 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 10)
        {
            SRMoney.sprite = Geto2;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statMoney <= 9 && GameObject.Find("window").GetComponent<Stats>().statMoney >= 0)
        {
            SRMoney.sprite = Geto1;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain >= 90)
        {
            SRMain.sprite = Riko11;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain >= 89 && GameObject.Find("window").GetComponent<Stats>().statmain >= 80)
        {
            SRMain.sprite = Riko10;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 79 && GameObject.Find("window").GetComponent<Stats>().statmain >= 70)
        {
            SRMain.sprite = Riko9;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 69 && GameObject.Find("window").GetComponent<Stats>().statmain >= 60)
        {
            SRMain.sprite = Riko8;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 59 && GameObject.Find("window").GetComponent<Stats>().statmain >= 50)
        {
            SRMain.sprite = Riko7;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 49 && GameObject.Find("window").GetComponent<Stats>().statmain >= 40)
        {
            SRMain.sprite = Riko6;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 39 && GameObject.Find("window").GetComponent<Stats>().statmain >= 30)
        {
            SRMain.sprite = Riko5;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 29 && GameObject.Find("window").GetComponent<Stats>().statmain >= 20)
        {
            SRMain.sprite = Riko4;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 19 && GameObject.Find("window").GetComponent<Stats>().statmain >= 15)
        {
            SRMain.sprite = Riko3;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 14 && GameObject.Find("window").GetComponent<Stats>().statmain >= 10)
        {
            SRMain.sprite = Riko2;
        }
        if (GameObject.Find("window").GetComponent<Stats>().statmain <= 9 && GameObject.Find("window").GetComponent<Stats>().statmain >= 0)
        {
            SRMain.sprite = Riko1;
        }
    }
}
