using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    [Tooltip("Only tweak this variable if this door isn't connected to any switch!")]
    public float requiredCharge;
    public float currentCharge;

    public GameObject doorIndi;
    Renderer doorFeedback;

    void Start()
    {
        doorFeedback = doorIndi.GetComponent<Renderer>();
    }

    public void DoorCheck(float amountOfCharge) {
        currentCharge += amountOfCharge;

        if (currentCharge >= requiredCharge) {
            doorFeedback.material.color = Color.yellow;
            gameObject.SetActive(false);
        }
    }
}