using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private float speed = 10.0F;
	[SerializeField]
	private float rotationSpeed = 100.0F;

	// Update is called once per frame
	void Update()
	{
		PlayerMove();
	}
	
	void PlayerMove()
	{
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}
}