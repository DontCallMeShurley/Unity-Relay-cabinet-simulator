using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vkl : MonoBehaviour
{
    public DialInteractable m_T;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_T.step1 == 1)
        {
            GameObject.Find("OLight").GetComponent<Light>().enabled = true;
            GameObject.Find("OLight (1)").GetComponent<Light>().enabled = true;
            GameObject.Find("GLight").GetComponent<Light>().enabled = true;
            GameObject.Find("RunLight").GetComponent<Light>().enabled = true;
        }
        else
        {
            GameObject.Find("OLight").GetComponent<Light>().enabled = false;
            GameObject.Find("OLight (1)").GetComponent<Light>().enabled = false;
            GameObject.Find("GLight").GetComponent<Light>().enabled = false;
            GameObject.Find("RunLight").GetComponent<Light>().enabled = false;
        }
    }
}
