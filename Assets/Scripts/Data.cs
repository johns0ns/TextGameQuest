using System.Collections;
using System.Collections.Generic;
using UnityEngine;





[CreateAssetMenu(menuName ="Data Asset")] //любое имя для пункта меню
public class Data : ScriptableObject
{

    [TextArea(minLines: 10, maxLines: 30)] public string content = "Я приветствую тебя в квесте ";
    public Data[] nextStep;
    public Sprite Image;
    public Color StepColor;

}
