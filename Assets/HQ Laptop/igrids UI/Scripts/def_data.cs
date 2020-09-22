using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class def_data : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("InputField_Step").GetComponent<InputField>().text = "0,1";
        GameObject.Find("InputField_Ito").GetComponent<InputField>().text = "0,7";
        GameObject.Find("InputField_I").GetComponent<InputField>().text = "0";
    }

    
}
