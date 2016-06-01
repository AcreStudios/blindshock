using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour, IInteractable {

    [Tooltip("The maximum amount of charges you can put in this switch.")]
    public float maxCharge;
    [Tooltip("The door this switch is suppose to connect to.")]
    public Door connectedDoor;
    [Tooltip("The circuit this switch is suppose to connect to.")]
    public GameObject eletricCiruit;
    float charge;

    void Start() {
        connectedDoor.requiredCharge += maxCharge;
    }

    public void Interact() {
        Debug.Log("Working");
        if (charge < maxCharge)
        {
            connectedDoor.DoorCheck(1);
            GetComponent<Renderer>().material.color = Color.green;
            eletricCiruit.SetActive(true);
        }
        else
            connectedDoor.DoorCheck(0);

        charge += 1;
    }
}
