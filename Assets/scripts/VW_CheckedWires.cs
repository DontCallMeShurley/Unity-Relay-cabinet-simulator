using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VW_CheckedWires : MonoBehaviour
{
    public string Ia, Ib, Ic, Ua, Ub, Uc;
    
    public bool isRight = false;
    public void OnSelectExit(string name)
    {
        var VW_CheckedWires = GameObject.Find("WiresChecked").GetComponent<VW_CheckedWires>();
        var UI_TextSocket = typeof(VW_CheckedWires).GetField(name);
        if (UI_TextSocket != null)
            UI_TextSocket.SetValue(VW_CheckedWires, "");
    }

    public void Checked()
    {
        Renderer[] lChildRenderers = GameObject.Find("Electro").GetComponentsInChildren<Renderer>();
        Renderer[] lChildRenderersP = GameObject.Find("Obi Solver").GetComponentsInChildren<Renderer>();
        Renderer[] lChildRenderersCP = GameObject.Find("Cube_Pins").GetComponentsInChildren<Renderer>();

        if (GameObject.Find("Plane.005").GetComponent<Renderer>().enabled == false)
        {
            GameObject.Find("Uc_Pin").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Ub_Pin").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Ua_Pin").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Ia_Pin").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Ib_Pin").GetComponent<Renderer>().enabled = true;
            GameObject.Find("Ic_Pin").GetComponent<Renderer>().enabled = true;
            foreach (Renderer lRenderer in lChildRenderers)
            {
                lRenderer.enabled = true;
            }
        }
        else
        {
            if ((Ia == "Ia_Pin" && Ib == "Ib_Pin" && Ic == "Ic_Pin" && Ua == "Ua_Pin" && Ub == "Ub_Pin" && Uc == "Uc_Pin") == true)
            {
                GameObject.Find("Uc_Pin").GetComponent<Renderer>().enabled = false;
                GameObject.Find("Ub_Pin").GetComponent<Renderer>().enabled = false;
                GameObject.Find("Ua_Pin").GetComponent<Renderer>().enabled = false;
                GameObject.Find("Ia_Pin").GetComponent<Renderer>().enabled = false;
                GameObject.Find("Ib_Pin").GetComponent<Renderer>().enabled = false;
                GameObject.Find("Ic_Pin").GetComponent<Renderer>().enabled = false;
                foreach (Renderer lRenderer in lChildRenderers)
                {
                    lRenderer.enabled = false;
                }
                foreach (Renderer lRendererP in lChildRenderersP)
                {
                    lRendererP.enabled = true;
                }
                foreach (Renderer lRendererCP in lChildRenderersCP)
                {
                    lRendererCP.enabled = true;
                }

                GameObject.Find("WarningText").GetComponent<Text>().enabled = false;
            }
            else GameObject.Find("WarningText").GetComponent<Text>().enabled = true;
        }

    }
}
