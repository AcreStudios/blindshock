using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

    [Tooltip("Only tweak this variable if this door isn't connected to any switch!")]
    public float requiredCharge;
    public float currentCharge;

    public GameObject doorIndi;
    Renderer doorFeedback;

    void Start()
    {
        doorFeedback = doorIndi.GetComponent<Renderer>();
    }

    public void DoorCheck(float amountOfCharge)
	{
        currentCharge += amountOfCharge;

        if (currentCharge >= requiredCharge)
		{
            doorFeedback.material.color = Color.green;
			//gameObject.SetActive(false);
			StartCoroutine(DoorSlide(transform.position + Vector3.left * 1.4f, 0.2f));
        }
    }

	IEnumerator DoorSlide(Vector3 pos, float speed)
	{
		while(transform.position != pos)
		{
			transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
			yield return null;
		}
	}
}