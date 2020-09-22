using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tgl_Act : MonoBehaviour
{
    
    public Toggle m_Toggle1;
    public Toggle m_Toggle2;
    public Toggle m_Toggle3;


    void Start()
    {
        //Fetch the Toggle GameObject
        
        //Add listener for when the state of the Toggle changes, to take action
        m_Toggle1.onValueChanged.AddListener(delegate {
            ToggleValueChanged(gameObject.GetComponent<InputField>().text);});
        m_Toggle2.onValueChanged.AddListener(delegate {
            ToggleValueChanged(gameObject.GetComponent<InputField>().text);
        });
        m_Toggle3.onValueChanged.AddListener(delegate {
            ToggleValueChanged(gameObject.GetComponent<InputField>().text);
        });
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(string text)
    {
        bool T1 = m_Toggle1.isOn;
        bool T2 = m_Toggle2.isOn;
        bool T3 = m_Toggle3.isOn;

        if ((T1 == true) & (T2 == true) & (T3==false)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1,5"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,05"; }
       else if ((T1 == true) & (T3 == true) & (T2 == false)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,05"; }
        else if ((T2 == true) & (T3 == true) & (T1 == false)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,5"; }
        else if ((T1 == true) & (T2 == true) & (T3==true)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,05"; }

       else if ((T1 == true) & (T2 == false) & (T3 == false)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "2"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,05"; }
       else if ((T1 == false) & (T2 == true) & (T3 == false)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1,5"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "0,5"; }
       else if ((T1 == false) & (T2 == false) & (T3 == true)) { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = "1"; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = "1"; }
        else { GameObject.Find("InputField_Iact").GetComponent<InputField>().text = ""; GameObject.Find("InputField_Kb").GetComponent<InputField>().text = ""; }
    }

    }
