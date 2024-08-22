using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetValue : MonoBehaviour
{

    int dataTokeep;
    public void LoadSceneAndKeepValue ()
    {
        
        dataTokeep ++;
        staticdata.valueTokeep = dataTokeep;
        SceneManager.LoadScene("LoadData");
        
    }
    public void LoadSceneAndKeepValue2()
    {
        dataTokeep++;
        staticdata.valueTokeep = dataTokeep;
        SceneManager.LoadScene("SaveData");
    }
}
