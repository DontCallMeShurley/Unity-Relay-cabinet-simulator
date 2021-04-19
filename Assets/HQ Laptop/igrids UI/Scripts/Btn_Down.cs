using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Btn_Down : MonoBehaviour
{

    public void TaskOnClick()
    {
        double I; 
        double a = Convert.ToDouble(GameObject.Find("InputField_Step").GetComponent<InputField>().text);
        double b = Convert.ToDouble(GameObject.Find("InputField_I").GetComponent<InputField>().text);
        I = Math.Round((b - a),2);
        if (I < 0) I= 0;
        string str_I = Convert.ToString(I);
        GameObject.Find("InputField_I").GetComponent<InputField>().text = str_I;
       if (GameObject.Find("vkl").GetComponent<DialInteractable>().step1 == 1)
       {
            GameObject.Find("Ia (1)").GetComponent<Text>().text = str_I;
            GameObject.Find("Ib (1)").GetComponent<Text>().text = str_I;
            GameObject.Find("Ic (1)").GetComponent<Text>().text = str_I;
       }


    }
}