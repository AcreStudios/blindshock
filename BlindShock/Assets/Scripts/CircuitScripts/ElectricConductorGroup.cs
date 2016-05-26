using UnityEngine;
using System.Collections;

public class ElectricConductorGroup : ElectricConductor {

    public override void VoltageFlow() {

        foreach (Transform subWires in transform) {
            subWires.GetComponent<Renderer>().material.color = charge > 0 ? Color.yellow : Color.white;
        }

        if (predecessorWire != null) {
            predecessorWire.charge += chargeValue;
            predecessorWire.chargeValue = chargeValue;
            //predecessorWire.chargeTravelTime = chargeTravelTime;
            predecessorWire.VoltageFlow();
        }
    }
}
