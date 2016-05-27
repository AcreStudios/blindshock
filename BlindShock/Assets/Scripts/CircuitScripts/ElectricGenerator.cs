using UnityEngine;
using System.Collections;

public class ElectricGenerator : ElectricConductor { 

    void Start() {
        chargeValue = 1;
        VoltageFlow();
    }

}
