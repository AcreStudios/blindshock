using UnityEngine;
using System.Collections;

public class InteractionScript : MonoBehaviour {

    RaycastHit hit;
    public float currentCharge;

    void Start() {

    }

    void Update() {
        if (Input.GetKeyDown("e")) {
            if (Physics.Raycast(transform.position,transform.TransformDirection(0,0,1), out hit, 5)) {
                if (hit.transform.gameObject.GetComponent<MonoBehaviour>() is IInteractable) {
                    Debug.Log("Working");
                    hit.transform.gameObject.GetComponent<IInteractable>().Interact();
                }
            }
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(0, 0, 1), Color.red);
    }
}
