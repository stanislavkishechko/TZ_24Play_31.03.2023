using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


	[SerializeField] private PlayerStuck playerStuck;
	[SerializeField] private GameObject cubeStackEffect;


	private Vector3 direction = Vector3.back;
	private bool isStack = false;
	private RaycastHit hit;


	private void Start()
	{
		playerStuck = GameObject.FindObjectOfType<PlayerStuck>();
		cubeStackEffect.SetActive(false);
	}


	void FixedUpdate()
	{
		if (Physics.Raycast(transform.position, direction, out hit, 1f))
		{
			if (!isStack)
			{
				isStack = !isStack;
				playerStuck.IncreaseNewBlock(gameObject);
				cubeStackEffect.SetActive(true);
				SetDirection();
			}

			if (hit.transform.name == "CubeWall")
			{
				playerStuck.DecreaseBlock(gameObject);
			}
		}
	}

	private void SetDirection()
	{
		direction = Vector3.forward;
	}
}
