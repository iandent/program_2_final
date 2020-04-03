using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void PlayGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void PlayYellowGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

	public void PlayGreenGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}

	public void PlayBlueGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
	}

	public void PlayTruckGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
	}

	public void PlayAmbulanceGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
	}

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
    
}
