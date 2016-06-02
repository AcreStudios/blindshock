using UnityEngine;
using System.Collections;

public class Electricity : MonoBehaviour {

    [Tooltip("Must be placed in order. Put direction of current in accending order.")]
    public Electricity_Visuals[] points;

    public void Start() {
        for (int i = 0; i < points.Length; i++)
        {
            points[i].lineRend = points[i].gameObject.GetComponent<LineRenderer>();
            points[i].lineRend.SetVertexCount(points[i].numberOfSegments);

            points[i].startPos = points[i].transform;
            if (i + 1 != points.Length)
                points[i].endPos = points[i + 1].transform;
            else
                points[i].endPos = points[0].transform;
            points[i].RandomizePositions();
        }
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(0.0f);
        
    }

}
