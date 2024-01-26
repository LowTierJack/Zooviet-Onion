using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    // kod gjord av jack
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public int happyMod;
    public int moneyMod;
    
    public GameObject dialogue1, dialogue2, dialogue3, dialogue4, dialogue5, dialogue6, dialogue7;

    int whattoSpawn;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (index == lines.Length - 1)
        { 
                if (Input.GetKey(KeyCode.Y))
            {
                int whattoSpawn = Random.Range(1, 8);
                print("Ýes");
                switch (whattoSpawn)
                {
                    case 1:
                        Instantiate(dialogue1, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(dialogue2, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(dialogue3, transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(dialogue4, transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(dialogue5, transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(dialogue6, transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(dialogue7, transform.position, Quaternion.identity);
                        break;

                }
                GameObject.Find("window").GetComponent<Stats>().statHappiness += happyMod;
                GameObject.Find("window").GetComponent<Stats>().statMoney += moneyMod;
                gameObject.SetActive(false);
            }

            if (Input.GetKey(KeyCode.N))
            {
                int whattoSpawn = Random.Range(1, 4);
                print("No");
                switch (whattoSpawn)
                {
                    case 1:
                        Instantiate(dialogue1, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(dialogue2, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(dialogue3, transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(dialogue4, transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(dialogue5, transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(dialogue6, transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(dialogue7, transform.position, Quaternion.identity);
                        break;

                }
                GameObject.Find("window").GetComponent<Stats>().statHappiness -= happyMod;
                GameObject.Find("window").GetComponent<Stats>().statMoney -= moneyMod;
                gameObject.SetActive(false);

            }



        }
        else {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            
        }
    }
}