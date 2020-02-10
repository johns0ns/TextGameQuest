﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextGameQuest : MonoBehaviour
{
    [Header("Элементы")]
    public Text titleText;
    public Text gametext;
    public Image gameimage;


    [Header("Конфиг")]
    public string title = "Приветули мой френд, сейчас мы сыграем в текстовый квест Монте-Кристо";
    public Step activeStep;

    void Start()
    {
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
        if ((Input.GetKeyDown(KeyCode.Alpha2)) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            CheckPress(1);
                gameimage.sprite = activeStep.Image;
        }

        if ((Input.GetKeyDown(KeyCode.Alpha3)) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            CheckPress(2);
            gameimage.sprite = activeStep.Image;
        }
        if ((Input.GetKey(KeyCode.Q)) && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            Start();
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
