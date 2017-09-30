using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject deadPanel;
    public GameObject pausePanel;
	
	// Update is called once per frame
	void Update () {
        if (!deadPanel.activeInHierarchy)      
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pausePanel.activeInHierarchy)
                {
                    pausePanel.SetActive(false);
                    Time.timeScale = 1;
                }
                else
                {
                    pausePanel.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
	}
}
