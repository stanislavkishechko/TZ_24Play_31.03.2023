using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{


	[SerializeField] private Button tryAgainButton;


	private void Awake()
	{
		tryAgainButton.onClick.AddListener(() =>
		{
			SceneManager.LoadScene("GameScene");
		});
	}

	private void Start()
	{
		Hide();
	}

	public void Show()
	{
		gameObject.SetActive(true);
	}

	private void Hide()
	{
		gameObject.SetActive(false);
	}
}
