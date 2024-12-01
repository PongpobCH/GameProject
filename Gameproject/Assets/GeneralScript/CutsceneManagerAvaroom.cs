using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CutsceneManagerAVARoom : MonoBehaviour
{
    public Animator AnimationForCutscene01;
    
    
    public GameObject Cutscene01;
    
    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    //public GameObject ClickNextTextbutton;
    public LevelLoader LevelLoadscript;
    public GameObject violin;

    void Start()
    {
        
       SetAllcutsceneNotActive();
        
    }

    public void SetAllcutsceneNotActive()
    {
        Cutscene01.SetActive(false);
        
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
        violin.SetActive(false);
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
         Invoke("loadminigame01", 2);


    }

    public void loadminigame01(){
        LevelLoadscript.loadminigamepetting();
    }


}