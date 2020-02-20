using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{

    public Data dataAsset;
    




    [Header("Элементы")]
    public Text titleText;
    public Text gametext;
    public Image gameimage;


    [Header("Конфиг")]
    public string title = "Приветули мой френд, сейчас мы сыграем в текстовый квест Монте-Кристо";
    public Font Шрифт;
    public Data activeStep;
   // Step firstStep;

    void Start()
    {
        //firstStep = activeStep;
        titleText.text = title;
        gametext.text = activeStep.content;
        

    }


    void Update()
    {

        if((Input.GetKeyDown(KeyCode.Alpha1)) || (Input.GetKeyDown(KeyCode.Keypad1)))
        {
            CheckPress(0);
                gameimage.sprite = activeStep.Image;
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha2)) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            CheckPress(1);
                gameimage.sprite = activeStep.Image;
        }

        else if ((Input.GetKeyDown(KeyCode.Alpha3)) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            CheckPress(2);
            gameimage.sprite = activeStep.Image;
        }
        else if ((Input.GetKey(KeyCode.Q))  && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(0);
        }
    }



void CheckPress(int index)
    {
        if (activeStep.nextStep.Length > index)
        {
            activeStep = activeStep.nextStep[index];
            gametext.text = activeStep.content;

        }

    }
}
