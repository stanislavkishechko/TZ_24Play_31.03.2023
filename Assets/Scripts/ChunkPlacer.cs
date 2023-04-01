using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{


	[SerializeField] private Transform player;
	[SerializeField] private Chunk[] chunkPrefabs;
	[SerializeField] private Chunk firstChunk;

	private List<Chunk> spawnedChunks = new List<Chunk>();

	private void Start()
	{
		spawnedChunks.Add(firstChunk);

	}

	private void Update()
	{
		if (player.position.z > spawnedChunks[spawnedChunks.Count - 1].End.position.z - 17f)
		{
			SpawnChunk();
		}				
	}

	private void SpawnChunk()
	{
		Chunk newChunk = Instantiate(chunkPrefabs[Random.Range(0, chunkPrefabs.Length)]);
		newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
		spawnedChunks.Add(newChunk);

		if (spawnedChunks.Count >= 3)
		{
			Destroy(spawnedChunks[0].gameObject);
			spawnedChunks.RemoveAt(0);
		}
	}

}
