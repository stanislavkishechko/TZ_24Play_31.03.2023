using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private GameOverUI gameOverUI;
	[SerializeField] private GameStartUI gameStartUI;

	public static GameManager Instance { get; private set; }

	public bool isGameOver = false;

	private void Start()
	{
		Instance = this;

		Time.timeScale = 0f;
	}

	public void StartGame()
	{
		Time.timeScale = 1.0f;
	}

	public void GameOver()
	{
		gameOverUI.Show();
		Time.timeScale = 0f;
	}
}
