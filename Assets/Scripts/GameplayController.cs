using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {
	[SerializeField]

	private GameObject pausePanel;

void awake()
	{
		pausePanel.SetActive (false);
	}



	// Use this for initialization

	public void PauseGame () {
		Time.timeScale = 0f;
		pausePanel.SetActive (true);

	}
	
	// Update is called once per frame

	public void ResumeGame () {
		Time.timeScale = 1f;
		pausePanel.SetActive (false);

	}
	public void MainMenu () {
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");

	}

}
