using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CutsceneManagerDay03 : MonoBehaviour
{
    public Animator AnimationForCutscene01;
    public Animator AnimationForCutscene02;
    
    
    public GameObject Cutscene01;
    public GameObject Cutscene02;
    
    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    //public GameObject ClickNextTextbutton;
    public LevelLoader LevelLoadscript;

    void Start()
    {
        
       SetAllcutsceneNotActive();
        
    }

    public void SetAllcutsceneNotActive()
    {
        Cutscene01.SetActive(false);
        Cutscene02.SetActive(false);
        
    }
    public void CheckRow()

    {
        RowCheckingValue = GameManager2.Instance.RowData;
        Debug.Log("Row Checked from Server " + RowCheckingValue);
    }

    public void Playcutscene01()
    {
        Cutscene01.SetActive(true);
        //ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene01());
    }

     public void DeactivateCutscene01()
    {
        StartCoroutine(EndCutscene01());
    }

    private IEnumerator StartCutscene01()
    {
        //Debug.Log("start Cutscene");
        AnimationForCutscene01.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene01();
    }

    private IEnumerator EndCutscene01()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene01.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         //ClickNextTextbutton.SetActive(true); 

    }

    public void Playcutscene02()
    {
        Cutscene02.SetActive(true);
        //ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene02());
        //violin.SetActive(false);
    }

     public void DeactivateCutscene02()
    {
        StartCoroutine(EndCutscene02());
    }

    private IEnumerator StartCutscene02()
    {
        //Debug.Log("start Cutscene");
        AnimationForCutscene02.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene02();
    }

    private IEnumerator EndCutscene02()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene02.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         //ClickNextTextbutton.SetActive(true);


    }


}