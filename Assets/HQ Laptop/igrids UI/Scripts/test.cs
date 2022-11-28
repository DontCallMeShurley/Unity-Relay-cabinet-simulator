using System;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    public DialInteractable m_Toggle1;
    public DialInteractable m_Toggle2;
    public DialInteractable m_Toggle3;
    public DialInteractable m_ToggleON;
    // Start is called before the first frame update
    void Start() => gameObject.GetComponent<InputField>().onValueChanged.AddListener(delegate { ValueChahgeCheck(gameObject.GetComponent<InputField>().text); });


    void Update()
    {

    }
    void ValueChahgeCheck(string text)
    {
        double I = Convert.ToDouble(GameObject.Find("InputField_I").GetComponent<InputField>().text);
        double Iact = Convert.ToDouble(GameObject.Find("InputField_Iact").GetComponent<InputField>().text);
        double Ito = Convert.ToDouble(GameObject.Find("InputField_Ito").GetComponent<InputField>().text);

        if (I >= Iact)
        {
            GameObject.Find("YLight").GetComponent<Light>().enabled = true;
            Invoke("Led", float.Parse(GameObject.Find("InputField_Kb").GetComponent<InputField>().text));

        }
        if (I < Iact) { CancelInvoke("Led"); }
        if (I <= Ito)
        {

            GameObject.Find("RTLight1").GetComponent<Light>().enabled = false;
            GameObject.Find("RTLight2").GetComponent<Light>().enabled = false;
            GameObject.Find("RTLight3").GetComponent<Light>().enabled = false;
        }
    }
    void Led()
    {
        if (m_ToggleON.step1 != 0)
        {

            int T1 = m_Toggle1.step1;
            int T2 = m_Toggle2.step1;
            int T3 = m_Toggle3.step1;
            if ((T1 == 1) & (T2 == 1) & (T3 == 0))
            {
                GameObject.Find("RTLight1").GetComponent<Light>().enabled = true;
                GameObject.Find("RTLight2").GetComponent<Light>().enabled = true;
            }
            else if ((T1 == 1) & (T3 == 1) & (T2 == 0))
            {
                GameObject.Find("RTLight1").GetComponent<Light>().enabled = true;
                GameObject.Find("RTLight3").GetComponent<Light>().enabled = true;
            }
            else if ((T2 == 1) & (T3 == 1) & (T1 == 0))
            {
                GameObject.Find("RTLight2").GetComponent<Light>().enabled = true;
                GameObject.Find("RTLight3").GetComponent<Light>().enabled = true;
            }
            else if ((T1 == 1) & (T2 == 1) & (T3 == 1))
            {
                GameObject.Find("RTLight1").GetComponent<Light>().enabled = true;
                GameObject.Find("RTLight2").GetComponent<Light>().enabled = true;
                GameObject.Find("RTLight3").GetComponent<Light>().enabled = true;
            }

            else if ((T1 == 1) & (T2 == 0) & (T3 == 0))
            {
                GameObject.Find("RTLight1").GetComponent<Light>().enabled = true;
            }
            else if ((T1 == 0) & (T2 == 1) & (T3 == 0))
            {
                GameObject.Find("RTLight2").GetComponent<Light>().enabled = true;
            }
            else if ((T1 == 0) & (T2 == 0) & (T3 == 1))
            {
                GameObject.Find("RTLight3").GetComponent<Light>().enabled = true;
            }
        }
    }
}
