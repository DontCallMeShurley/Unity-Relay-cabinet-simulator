using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;
using UnityScript.Steps;

public class tubbler2 : MonoBehaviour
{

    public DialInteractable m_Toggle1;
    public DialInteractable m_Toggle2;
    public DialInteractable m_Toggle3;
    public DialInteractable m_ToggleON;
    int a = 0;
    void Update()
    {
        if (m_Toggle3.step1 != a) { Activate();
            a = m_Toggle3.step1;
        }
    }
   public void Activate()
    {
        if (m_Toggle3.step1 != 0)
        {

            int T1 = m_Toggle1.step1;
            int T2 = m_Toggle2.step1;
            int T3 = m_Toggle3.step1;
            bool mtz1 = GameObject.Find("MTZLight1").GetComponent<Light>().enabled;
            bool mtz2 = GameObject.Find("MTZLight2").GetComponent<Light>().enabled;
            bool mtz3 = GameObject.Find("MTZLight3").GetComponent<Light>().enabled;

            string InputField_Iact;
            string InputField_Kb;

            if ((T1 == 1) & (T2 == 1) & (T3 == 0))
            {
                InputField_Iact = "1,5"; InputField_Kb = "0,05"; mtz1 = true; mtz2 = true; mtz3 = false;
            }
            else if ((T1 == 1) & (T3 == 1) & (T2 == 0))
            {
                InputField_Iact = "1"; InputField_Kb = "0,05"; mtz1 = true; mtz2 = false; mtz3 = true;
            }
            else if ((T2 == 1) & (T3 == 1) & (T1 == 0))
            {
                InputField_Iact = "1"; InputField_Kb = "0,5"; mtz1 = false; mtz2 = true; mtz3 = true;
            }
            else if ((T1 == 1) & (T2 == 1) & (T3 == 1))
            {
                InputField_Iact = "1"; InputField_Kb = "0,05"; mtz1 = true; mtz2 = true; mtz3 = true;
            }

            else if ((T1 == 1) & (T2 == 0) & (T3 == 0))
            {

                InputField_Iact = "2"; InputField_Kb = "0,05"; mtz1 = true; mtz2 = false; mtz3 = false;
            }
            else if ((T1 == 0) & (T2 == 1) & (T3 == 0))
            {

                InputField_Iact = "1,5"; InputField_Kb = "0,5"; mtz1 = false; mtz2 = true; mtz3 = false;
            }
            else if ((T1 == 0) & (T2 == 0) & (T3 == 1))
            {

                InputField_Iact = "1"; InputField_Kb = "1"; mtz1 = false; mtz2 = false; mtz3 = true;
            }
            else
            {

                InputField_Iact = ""; InputField_Kb = ""; mtz1 = false; mtz2 = false; mtz3 = false;
            }

            GameObject.Find("InputField_Iact").GetComponent<InputField>().text = InputField_Iact;
            GameObject.Find("InputField_Kb").GetComponent<InputField>().text = InputField_Kb;
            GameObject.Find("MTZLight1").GetComponent<Light>().enabled = mtz1;
            GameObject.Find("MTZLight2").GetComponent<Light>().enabled = mtz2;
            GameObject.Find("MTZLight3").GetComponent<Light>().enabled = mtz3;
        }
        else
        {
            GameObject.Find("MTZLight1").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight2").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight3").GetComponent<Light>().enabled = false;
            GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "";
            GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "";
        }

    }


}