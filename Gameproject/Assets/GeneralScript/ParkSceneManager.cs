using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;


public class ParkSceneManager : MonoBehaviour
{
    public GameObject TutorialUI;
    public GameObject ObjectiveUI;
    public playerMovement playerscript;


    
    void Start()
    {   
        ObjectiveUI.SetActive(false);
        playerscript.enabled = false;

    }
    public void CloseUI()
    {

        TutorialUI.gameObject.SetActive(false);
        playerscript.enabled = true;
        ObjectiveUI.SetActive(true);

    }







}
