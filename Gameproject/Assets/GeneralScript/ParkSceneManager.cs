using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;


public class ParkSceneManager : MonoBehaviour
{
    public GameObject TutorialUI;
    public GameObject ObjectiveUI;

    public GameObject Avasprite;
    public GameObject DialogUI;
    public playerMovement playerscript;


    
    void Start()
    {   
        Avasprite.SetActive(false);
        DialogUI.SetActive(false);
        ObjectiveUI.SetActive(false);
        playerscript.enabled = false;

    }
    public void CloseUI()
    {

        TutorialUI.gameObject.SetActive(false);
        playerscript.enabled = true;
        ObjectiveUI.SetActive(true);

    }
    public void cutin1()
    {
        ObjectiveUI.SetActive(false);
        Avasprite.SetActive(true);
        DialogUI.SetActive(true);
    }

    public void closecutin()
    {
        ObjectiveUI.SetActive(true);
        Avasprite.SetActive(false);
        DialogUI.SetActive(false);
    }







}
