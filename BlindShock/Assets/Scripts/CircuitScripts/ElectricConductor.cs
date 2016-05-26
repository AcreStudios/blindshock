using UnityEngine;
using System.Collections;

public class ElectricConductor : MonoBehaviour {

    public ElectricConductor predecessorWire;
    [HideInInspector]public ElectricConductor storageWire;

    public float charge;
    public float chargeValue;
    Renderer render;

    void Start() {
        storageWire = predecessorWire;
        if (GetComponent<Renderer>()) 
            render = GetComponent<Renderer>();
    }

    public virtual void VoltageFlow() {
        if (render != null) {
           render.material.color = charge > 0 ? Color.yellow : Color.white;
        }

        if (predecessorWire != null) {
            predecessorWire.charge += chargeValue;
            predecessorWire.chargeValue = chargeValue;
            predecessorWire.VoltageFlow();
        }
    }
}
