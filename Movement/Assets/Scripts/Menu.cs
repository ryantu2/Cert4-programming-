using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    public GameObject menu, options;

	// Use this for initialization
	public void LoadScene (int sceneId)
    {
        SceneManager.LoadScene(sceneId);
	}
	
	// Update is called once per frame
	public void Exit ()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
	}

    public void ToggleOptions(bool toggle)
    {
        if (toggle)
        {
            menu.SetActive(false);
            options.SetActive(true);
        }
        else
        {
            menu.SetActive(true);
            options.SetActive(false);
        }
    }
}
