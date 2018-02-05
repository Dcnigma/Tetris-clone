using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {


	public void PlayGame ()
	{
		SceneManager.LoadScene ("MainGame");

	}

	public void Options ()
	{
		SceneManager.LoadScene ("Options");

	}

	public void Options_Back ()
	{
		SceneManager.LoadScene ("Menu");

	}
}
