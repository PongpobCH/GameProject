using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScenePark ()
    {
        SceneManager.LoadScene("Park");
    }
    public void LoadAvaRoom(){
        SceneManager.LoadScene("AvaRoom");
    }
    public void Loadbacktoday1(){

        SceneManager.LoadScene("Day1");

    }
}
