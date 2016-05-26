using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class EletricDeconductor : MonoBehaviour {

    ElectricConductor storage;

    void OnCollisionEnter(Collision collision) {
        if (storage == null) {
            if (collision.transform.root.gameObject.GetComponent<ElectricConductor>()) {
                storage = collision.transform.root.gameObject.GetComponent<ElectricConductor>();
                storage.chargeValue = -storage.charge;
                storage.VoltageFlow();

                if (storage.GetComponent<ElectricConductorGroup>()) {
                    foreach (Transform multipleWires in storage.transform) {
                        multipleWires.GetComponent<Renderer>().material.color = Color.white;
                    }
                } else {
                    storage.GetComponent<Renderer>().material.color = Color.white;
                }
                storage.predecessorWire = null;
            }
        }
    }

    void OnCollisionExit(Collision collision) {
        if (storage != null) {
            storage.chargeValue = storage.charge;
            storage.predecessorWire = storage.storageWire;
            storage.VoltageFlow();
            storage = null;
        }
    }
}
