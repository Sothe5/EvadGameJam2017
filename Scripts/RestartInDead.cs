using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInDead : MonoBehaviour {

    public GameObject deadPanel;

    // Update is called once per frame
    void Update()
    {
        if (deadPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(gameObject.scene.name);
            }
        }
    }
}
