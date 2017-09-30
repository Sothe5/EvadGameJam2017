using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInDead : MonoBehaviour {

    public GameObject deadPanel;
    public Camera footCamera;

    private bool loading;

    // Update is called once per frame
    void Update()
    {
        if (deadPanel.activeInHierarchy && !loading)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                loading = true;
                footCamera.enabled = false;
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
    }
}
