using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PanelUI : MonoBehaviour
{
    public DialInteractable m_ToggleON;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_ToggleON.step1 == 1) PanelUIon(); else PanelUIoff();
        
    }
    void PanelUIon()
    {
        Panel.SetActive(true);
        
    }
    void PanelUIoff()
    {

        Panel.SetActive(false);
        GameObject.Find("RTLight1").GetComponent<Light>().enabled = false;
        GameObject.Find("RTLight2").GetComponent<Light>().enabled = false;
        GameObject.Find("RTLight3").GetComponent<Light>().enabled = false;

    }
}
