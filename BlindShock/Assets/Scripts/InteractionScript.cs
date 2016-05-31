using UnityEngine;
using System.Collections;

public class InteractionScript : MonoBehaviour {

    RaycastHit hit;
    public bool hasCharge;

    void Update() {
        if (Input.GetKeyDown("e")) {
            if (Physics.Raycast(transform.position,transform.TransformDirection(0,0,1), out hit, 5)) {
                if (hit.transform.gameObject.GetComponent<MonoBehaviour>() is IInteractable) {
                    if (hasCharge) {
                        hit.transform.gameObject.GetComponent<IInteractable>().Interact();
                        hasCharge = false;
                    }
                }
                if (hit.transform.gameObject.GetComponent<Generator>()) {
                    hasCharge = true;
                }
                }
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(0, 0, 1), Color.red);
    }
}
