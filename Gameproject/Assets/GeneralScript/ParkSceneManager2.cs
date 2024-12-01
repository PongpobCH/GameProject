using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;


public class ParkSceneManager2 : MonoBehaviour
{
    public GameObject ObjectiveUI;

    public GameObject Avasprite;
    public GameObject DialogUI;
    public playerMovement playerscript;


    
    void Start()
    {   
        Avasprite.SetActive(false);
        //DialogUI.SetActive(false);
        ObjectiveUI.SetActive(false);
        playerscript.enabled = false;

    }
    public void closedialogUI(){

        DialogUI.SetActive(false);
        playerscript.enabled=true;
    }






}
