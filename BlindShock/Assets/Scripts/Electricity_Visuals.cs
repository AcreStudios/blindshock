using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class Electricity_Visuals : MonoBehaviour
{
    #region Variables
    public int numberOfSegments = 12;
    public float randomPositionOffset = 0.2f;

    public float lifetimeDuration = 1f;
    Color aColor = Color.white;
    public float decayRate = 5f; // Fade away rate after lifetime duration is up

    // Set by other scripts
    public Transform startPos;
    public Transform endPos;
    #endregion

    #region Cache components
    public LineRenderer lineRend;
    #endregion

    public void RandomizePositions()
    {
        for (int i = 0; i < numberOfSegments; i++)
        {
            float x = Mathf.Lerp(startPos.position.x, endPos.position.x, i / (numberOfSegments - 1f)) + Random.Range(-randomPositionOffset, randomPositionOffset);
            float y = Mathf.Lerp(startPos.position.y, endPos.position.y, i / (numberOfSegments - 1f)) + Random.Range(-randomPositionOffset, randomPositionOffset);
            float z = Mathf.Lerp(startPos.position.z, endPos.position.z, i / (numberOfSegments - 1f)) + Random.Range(-randomPositionOffset, randomPositionOffset);

            lineRend.SetPosition(i, new Vector3(x, y, z));
        }

		StartCoroutine(RebirthSelf());
    }

    IEnumerator RebirthSelf()
    {
        yield return new WaitForSeconds(lifetimeDuration);
        while (aColor.a > 0)
        {
            aColor.a -= decayRate * Time.deltaTime;
            lineRend.SetColors(aColor, aColor);

            yield return null;
        }

		RandomizePositions();
        aColor = Color.white;
        lineRend.SetColors(aColor, aColor);
    }
}
