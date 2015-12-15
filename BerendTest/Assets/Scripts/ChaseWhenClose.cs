using UnityEngine;
using System.Collections;

public class ChaseWhenClose : MonoBehaviour {
	[SerializeField]
	private int distanceStartingChasing = 1;

	[SerializeField]
	private GameObject objectToFollow;

	private bool shouldIChase = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(this.transform.position,objectToFollow.transform.position)<=distanceStartingChasing)
		{
			shouldIChase = true;
		}
		else
		{
			shouldIChase = false;
		}
		if(shouldIChase)
		{
			transform.LookAt(objectToFollow.transform.position);
			transform.Translate(Vector3.forward * Time.deltaTime);
		}
		else
		{
			//Als je niet meer hoeft te chasen
		}
	}
}
