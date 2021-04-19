using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Subclass of the classic Socket Interactor from the Interaction toolkit that will only accept object with the right
/// SocketTarget 
/// </summary>
public class XRExclusiveSocketInteractor : XRSocketInteractor
{
    public string AcceptedType;
    SocketTarget socketTarget;

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        socketTarget = interactable.GetComponent<SocketTarget>();
        
        if (socketTarget == null)
            return false;

         //Debug.Log(interactable.GetComponent<SocketTarget>().name);
        /*
        var VW_CheckedWires = GameObject.Find("WiresChecked").GetComponent<VW_CheckedWires>();
        var UI_TextSocket = typeof(VW_CheckedWires).GetField(interactable.gameObject.name);

        if (UI_TextSocket != null)
            UI_TextSocket.SetValue(VW_CheckedWires, interactable.gameObject.name);
        */

        return base.CanSelect(interactable) && (socketTarget.SocketType == AcceptedType);
    }

    public override bool CanHover(XRBaseInteractable interactable)
    {

        return CanSelect(interactable);
    }
}
