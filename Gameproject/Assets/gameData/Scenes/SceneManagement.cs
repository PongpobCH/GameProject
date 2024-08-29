using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour 
{
    public static SceneManagement Instance { get; private set; }

    private void Awake()
    {
        // Check if an instance already exists
        if (Instance == null)
        {
            // If not, set this instance as the singleton
            Instance = this;
            // Make sure this object persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this object
            //Destroy(gameObject);
        }
    }

    public void LoadbacktoDialog()
    {
        SceneManager.LoadScene("Dialogue01");
    }
}
