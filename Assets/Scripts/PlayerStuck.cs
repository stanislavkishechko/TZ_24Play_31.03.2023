using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStuck : MonoBehaviour
{


	public List<GameObject> blockList = new List<GameObject>();
	private GameObject lastBlockObject;


	private void Start()
	{
		UpdateLastBlockObject();			
	}

	public void IncreaseNewBlock(GameObject gameObject)
	{
		float blockHeight = 1f;

		transform.position = new Vector3(transform.position.x, transform.position.y + blockHeight, transform.position.z);
		gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - blockHeight, lastBlockObject.transform.position.z);
		gameObject.transform.SetParent(transform);
		blockList.Add(gameObject);
		UpdateLastBlockObject();
	}

	public void DecreaseBlock(GameObject gameObject)
	{
		gameObject.transform.parent = null;
		blockList.Remove(gameObject);
		UpdateLastBlockObject();
		Destroy(gameObject, 1.5f);
	}

	public void UpdateLastBlockObject()
	{
		lastBlockObject = blockList[blockList.Count - 1];
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.name == "CubeWall")
		{
			Debug.Log("Collision");
			GameManager.Instance.GameOver();
		}
	}

}
