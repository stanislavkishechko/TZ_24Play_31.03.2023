using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


	[SerializeField] private float forwardMovementSpeed;
	[SerializeField] private float horizontalMovementSpeed;
	[SerializeField] private float horizontalLimitValue;

	private float horizontalValue;


	private float newPositionX;


	void FixedUpdate()
	{		
		HandlePlayerHorizontalInput();
		SetPlayerForwardMovement();
		SetPlayerHorizontalMovement();		
	}

	private void HandlePlayerHorizontalInput()
	{
		if (Input.GetMouseButton(0))
		{
			horizontalValue = Input.GetAxis("Mouse X");
		}
		else
		{
			horizontalValue = 0;
		}
	}


	private void SetPlayerForwardMovement()
	{
		transform.Translate(Vector3.forward * forwardMovementSpeed * Time.fixedDeltaTime);
	}

	private void SetPlayerHorizontalMovement()
	{
		newPositionX = transform.position.x + horizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
		newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
		transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
	}
}
