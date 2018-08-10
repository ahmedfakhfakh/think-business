using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoaders : MonoBehaviour {

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadSceneOptions()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadSceneMaps()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSceneRoom()
    {
        SceneManager.LoadScene(2);
    }
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
