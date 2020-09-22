using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Btn_Up : MonoBehaviour
{

    public void TaskOnClick()
    {
        string I = Convert.ToString(Math.Round(Convert.ToDouble(GameObject.Find("InputField_Step").GetComponent<InputField>().text) +
             Convert.ToDouble(GameObject.Find("InputField_I").GetComponent<InputField>().text),2));
             
        GameObject.Find("InputField_I").GetComponent<InputField>().text = I ;
        GameObject.Find("Ia (1)").GetComponent<Text>().text = I;
        GameObject.Find("Ib (1)").GetComponent<Text>().text = I;
        GameObject.Find("Ic (1)").GetComponent<Text>().text = I;
        
    }
}