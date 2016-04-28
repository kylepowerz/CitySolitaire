using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public string mainMenu;
	public bool isPaused;
	public GameObject pauseMenuCanvas;
	
	// Update is called once per frame
	void Update () {

		if (isPaused) 
		{
			pauseMenuCanvas.SetActive (true);
		} else {
			pauseMenuCanvas.SetActive (false);
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
				
			isPaused = !isPaused;
		}

	}

	public void Resume()
	{
		isPaused = false;
	}

	public void Quit()
	{
		SceneManager.LoadScene ("menu");
	}
}
