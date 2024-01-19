using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stats : MonoBehaviour
{
    public int statHappiness;
    public int statMoney;
    public int statmain;
    public SpriteRenderer SR;
    public Sprite Gojo1;
    public Sprite Gojo2;
    public Sprite Gojo3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
  
    {
        if (statHappiness > 80)
        {
            SR.sprite = Gojo1;
        }
       
        if (statHappiness < 80 && statHappiness > 40)
        {
            SR.sprite = Gojo2;
        }
        
        if(statHappiness < 39 && statHappiness > 0)
        {
            SR.sprite = Gojo3;
        }

        print("HAPPY " + statHappiness);
        print("MONEY " + statMoney);
       
     

        
     
     
     }
}
