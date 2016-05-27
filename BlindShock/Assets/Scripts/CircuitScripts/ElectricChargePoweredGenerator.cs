using UnityEngine;
using System.Collections;

public class ElectricChargePoweredGenerator : ElectricConductor, IInteractable {

    bool currentFlowing;

    public void Interact() {
        if (currentFlowing) {
            currentFlowing = false;
            chargeValue = -1;
        } else {
            currentFlowing = true;
            chargeValue = 1;
        }
        VoltageFlow();
    }

}
