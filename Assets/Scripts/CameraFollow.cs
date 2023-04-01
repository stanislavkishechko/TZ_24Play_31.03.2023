using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


	[SerializeField] private Transform playerTransform;
	[SerializeField] private float lerpValue;


	private Vector3 newPosition;
	private Vector3 offset;


	void Start()
	{
		SetOffsetValue();
	}

	void LateUpdate()
	{		
		SetCameraSmoothFollow();		
	}

	private void SetOffsetValue()
	{
		offset = transform.position - playerTransform.position;
	}

	private void SetCameraSmoothFollow()
	{
		newPosition = Vector3.Lerp(transform.position, new Vector3(0f, playerTransform.position.y, playerTransform.position.z) + offset, lerpValue * Time.deltaTime);
		transform.position = newPosition;
	}
}
