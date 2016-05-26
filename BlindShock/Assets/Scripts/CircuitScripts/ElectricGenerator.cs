using UnityEngine;
using System.Collections;

public class ElectricGenerator : ElectricConductor {

    bool currentFlowing;

    void Start() {
    }

	void Update () {
        if (Input.GetKeyDown("q")) {
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
}
