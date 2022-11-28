using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_scrpt : MonoBehaviour
{
    public DialInteractable m_ToggleON;
    public void ON()
    {
        if (m_ToggleON.step1 == 1)
        {

            GameObject.Find("YLightTest").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight1Test").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight2Test").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight3Test").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight1_1").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight2_1").GetComponent<Light>().enabled = true;
            GameObject.Find("MTZLight3_1").GetComponent<Light>().enabled = true;

        }
    }

    public void OFF()
    {
        if (m_ToggleON.step1 == 1)
        {
            GameObject.Find("YLightTest").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight1Test").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight2Test").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight3Test").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight1_1").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight2_1").GetComponent<Light>().enabled = false;
            GameObject.Find("MTZLight3_1").GetComponent<Light>().enabled = false;
        }
    }
}
