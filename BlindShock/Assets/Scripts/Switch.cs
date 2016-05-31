using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour, IInteractable {

    [Tooltip("The maximum amount of charges you can put in this switch.")]
    public float maxCharge;
    [Tooltip("The door this switch is suppose to connect to.")]
    public Door connectedDoor;
    float charge;

    void Start() {
        connectedDoor.requiredCharge += maxCharge;
    }

    public void Interact() {
        if (charge < maxCharge)
            connectedDoor.DoorCheck(1);
        else
            connectedDoor.DoorCheck(0);
    }
}
