using UnityEngine;
using System.Collections;

public class Electricity : MonoBehaviour {

    [Tooltip("Must be placed in order. Put direction of current in accending order.")]
    public Electricity_Visuals[] points;

    public void Start() {
        for (int i = 0; i < points.Length; i++) {
            if (i == points.Length - 1) {
                points[i].gameObject.GetComponent<LineRenderer>().enabled = false;
                break;
            }
            points[i].startPos = points[i].transform;
            points[i].endPos = points[i + 1].transform;
            points[i].RandomizePositions();
        }
    }
}
