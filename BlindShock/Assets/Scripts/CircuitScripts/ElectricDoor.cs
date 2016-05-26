using UnityEngine;
using System.Collections;

public class ElectricDoor : ElectricConductor {

    public override void VoltageFlow() {
        transform.localScale = charge >0 ? new Vector3(transform.localScale.x, 0.5f, transform.localScale.z) : new Vector3(transform.localScale.x, 1, transform.localScale.z);
    }
}