using UnityEngine;
using System.Collections;

public class ElectricSwitch : ElectricConductor, IInteractable {

    public KeyCode switchControl;
    public bool openSwitch;

    public override void VoltageFlow() {
        if (!openSwitch)
            base.VoltageFlow();
    }

    public void Interact() {
        if (openSwitch) {
            chargeValue = charge;
            base.VoltageFlow();
            openSwitch = false;
        } else {
            chargeValue = -charge;
            base.VoltageFlow();
            openSwitch = true;
        }
    }
}
