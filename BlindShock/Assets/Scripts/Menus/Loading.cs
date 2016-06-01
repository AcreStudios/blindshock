using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(TimerThingy());
    }

    IEnumerator TimerThingy() {
        yield return new WaitForSeconds(5);
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("New Testing Chamber");
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
