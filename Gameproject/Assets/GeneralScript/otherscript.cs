using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class otherscript : MonoBehaviour
{
    private void Update()
    {
        
            //GameManager2.Instance.IncrementValue();
            //Debug.Log("Shared Value: " + GameManager2.Instance.sharedValue);
       
    }

    public void LoadSceneSaveData()
    {
        GameManager2.Instance.IncrementValueAndLoadScene1();
        //Debug.Log("Shared Value: " + GameManager2.Instance.sharedValue);
        
       
    }

    public void LoadSceneLoadData()
    {
         GameManager2.Instance.IncrementValueAndLoadScene2();
        //Debug.Log("Shared Value: " + GameManager2.Instance.sharedValue);
    }
}
