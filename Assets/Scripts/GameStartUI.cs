using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartUI : MonoBehaviour
{

	[SerializeField] private Button tapToPlayButton;


	private void Awake()
	{
		tapToPlayButton.onClick.AddListener(() =>
		{
			GameManager.Instance.StartGame();
			Hide();
		});
	}

	private void Start()
	{
		Show();
	}

	private void Show()
	{
		gameObject.SetActive(true);
	}
	private void Hide()
	{
		gameObject.SetActive(false);
	}
}
