using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CutsceneManagerPrologue : MonoBehaviour
{
    public Animator AnimationForCutscene01;
    public Animator AnimationForCutscene02;
    public Animator AnimationForCutscene03;
    public Animator AnimationForCutscene04;
    public Animator AnimationForCutscene05;
    public Animator AnimationForCutscene06;
    
    public GameObject Cutscene01;
    public GameObject Cutscene02;
    public GameObject Cutscene03;
    public GameObject Cutscene04;
    public GameObject Cutscene05;
    public GameObject Cutscene06;
    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    public GameObject ClickNextTextbutton;

    void Start()
    {
        
       SetAllcutsceneNotActive();
        
    }

    public void SetAllcutsceneNotActive()
    {
        Cutscene01.SetActive(false);
        Cutscene02.SetActive(false);
        Cutscene03.SetActive(false);
        Cutscene04.SetActive(false);
        Cutscene05.SetActive(false);
        Cutscene06.SetActive(false);
    }
    public void CheckRow()

    {
        RowCheckingValue = GameManager2.Instance.RowData;
        Debug.Log("Row Checked from Server " + RowCheckingValue);
    }

    public void Playcutscene01()
    {
        Cutscene01.SetActive(true);
        ClickNextTextbutton.SetActive(false);
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
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene02()
    {
        Cutscene02.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene02());
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
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene03()
    {
        Cutscene03.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene03());
    }

    public void DeactivateCutscene03()
    {
        StartCoroutine(EndCutscene03());
    }

     private IEnumerator StartCutscene03()
    {
        //Debug.Log("start Cutscene");
        AnimationForCutscene03.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
       // Debug.Log("CutSceneEnded");
        DeactivateCutscene03();
    }

    private IEnumerator EndCutscene03()
    {
       // Debug.Log("CutSceneEnded");
         AnimationForCutscene03.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene04()
    {
        Cutscene04.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene04());
    }

    public void DeactivateCutscene04()
    {
        StartCoroutine(EndCutscene04());
    }

     private IEnumerator StartCutscene04()
    {
        //Debug.Log("start Cutscene");
        AnimationForCutscene04.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene04();
    }

    private IEnumerator EndCutscene04()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene04.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene05()
    {
        Cutscene05.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene05());
    }

    public void DeactivateCutscene05()
    {
        StartCoroutine(EndCutscene05());
    }

     private IEnumerator StartCutscene05()
    {
        //Debug.Log("start Cutscene");
        AnimationForCutscene05.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene05();
    }

    private IEnumerator EndCutscene05()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene05.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene06()
    {
        Cutscene06.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene06());
    }

    public void DeactivateCutscene06()
    {
        StartCoroutine(EndCutscene06());
    }

     private IEnumerator StartCutscene06()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene06.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene06();
    }

    private IEnumerator EndCutscene06()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene06.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
}