using UnityEngine;
using System.Collections;

public class ElectricSwitch : ElectricConductor {

    public KeyCode switchControl;
    public bool openSwitch;

    void Update() {
        if (Input.GetKeyDown(switchControl)) {
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

    public override void VoltageFlow() {
        if (!openSwitch)
            base.VoltageFlow();
    }
}
