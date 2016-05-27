using UnityEngine;
using System.Collections;

public class ElectricChargePoweredGenerator : ElectricConductor, IInteractable {

    public InteractionScript playerInst;
    bool currentFlowing;

    public void Interact() {
        if (currentFlowing) {
            currentFlowing = false;
            playerInst.currentCharge += chargeValue;
            chargeValue = 0;
        } else {
            currentFlowing = true;
            chargeValue = playerInst.currentCharge;
            playerInst.currentCharge = 0;
        }
        VoltageFlow();
    }

}
