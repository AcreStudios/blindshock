using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    [Tooltip("Only tweak this variable if this door isn't connected to any switch!")]
    public float requiredCharge;
    public float currentCharge;

    public void DoorCheck(float amountOfCharge) {
        currentCharge += amountOfCharge;

        if (currentCharge >= requiredCharge) {
            Debug.Log("Open Door");
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}