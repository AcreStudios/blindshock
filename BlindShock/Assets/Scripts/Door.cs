using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    /// <summary>Only tweak this variable if this door isn't connected to any switch!</summary>
    [Tooltip("Only tweak this variable if this door isn't connected to any switch!")]
    public float requiredCharge;
    float currentCharge;

    public void DoorCheck(float amountOfCharge) {
        currentCharge += amountOfCharge;

        if (currentCharge >= requiredCharge) {
            Debug.Log("Open Door");
        }
    }
}