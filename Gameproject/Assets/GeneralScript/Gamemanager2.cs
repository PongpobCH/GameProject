using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 Instance { get; private set; }

    public int RowData = 0;
    public int Loadtimes = 0;

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

    public void SavedRow()
    {
       
        RowData++;
        Debug.Log("RowCount = " + RowData);
        
    }
    public void IncrementLoadtimes()
    {
        Loadtimes++;
        
    }

    
}
