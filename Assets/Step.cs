using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea(minLines: 10, maxLines: 30)] public string content = "Я приветствую тебя в квесте ";
    public Step[] nextStep;
    public Sprite Image;
    public Font font;
    


}
