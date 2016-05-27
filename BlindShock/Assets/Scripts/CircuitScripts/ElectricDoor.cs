using UnityEngine;
using System.Collections;

public class ElectricDoor : ElectricConductor, IInteractable {

    public InteractionScript playerInst;
    bool currentFlowing;
    public float requireCharge;

    Vector3 closedDoor;
    Vector3 openedDoor;
    void Start() {
        closedDoor = transform.localScale;
        openedDoor = new Vector3(transform.localScale.x/2, transform.localScale.y, transform.localScale.z); ;
    }

    public override void VoltageFlow() {
        transform.localScale = charge >= requireCharge ? openedDoor : closedDoor;
        //transform.position = charge >= requireCharge ? new Vector3(transform.position.x -0.9f, transform.position.y, transform.position.z) : new Vector3(transform.position.x + 0.9f, transform.position.y, transform.position.z);
        base.VoltageFlow();
    }

    public void Interact() {
        if (currentFlowing) {
            currentFlowing = false;
            playerInst.currentCharge += charge;
            charge = 0;
        } else {
            currentFlowing = true;
            charge = playerInst.currentCharge;
            playerInst.currentCharge = 0;
        }
        VoltageFlow();
    }
}