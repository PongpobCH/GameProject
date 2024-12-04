using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CutsceneManagerDay01 : MonoBehaviour
{
    public Animator AnimationForCutscene06;
    public Animator AnimationForCutscene07;
    public Animator AnimationForCutscene08;
    public Animator AnimationForCutscene09;
    public Animator AnimationForCutscene10;
    public Animator AnimationForCutscene11;
    public Animator AnimationForCutscene12;
    public Animator AnimationForCutscene13;
    public Animator AnimationForCutscene14;
    public Animator AnimationForCutscene15;
    public GameObject Cutscene06;
    public GameObject Cutscene07;
    public GameObject Cutscene08;
    public GameObject Cutscene09;
    public GameObject Cutscene10;
    public GameObject Cutscene11;
    public GameObject Cutscene12;
    public GameObject Cutscene13;
    public GameObject Cutscene14;
    public GameObject Cutscene15;

    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    public GameObject ClickNextTextbutton;

    void Start()
    {
        
       SetAllcutsceneNotActive();
        
    }

    public void SetAllcutsceneNotActive()
    {
        Cutscene06.SetActive(false);
        Cutscene07.SetActive(false);
        Cutscene08.SetActive(false);
        Cutscene09.SetActive(false);
        Cutscene10.SetActive(false);
        Cutscene11.SetActive(false);
        Cutscene12.SetActive(false);
        Cutscene13.SetActive(false);
        Cutscene14.SetActive(false);
        Cutscene15.SetActive(false);
        
    }
    public void CheckRow()

    {
        RowCheckingValue = GameManager2.Instance.RowData;
        Debug.Log("Row Checked from Server " + RowCheckingValue);
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
        yield return new WaitForSeconds(transitiontime + 3f);
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

    public void Playcutscene07()
    {
        Cutscene07.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene07());
    }

    public void DeactivateCutscene07()
    {
        StartCoroutine(EndCutscene07());
    }

     private IEnumerator StartCutscene07()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene07.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene07();
    }

    private IEnumerator EndCutscene07()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene07.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
    public void Playcutscene08()
    {
        Cutscene08.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene08());
    }

     public void DeactivateCutscene08()
    {
        StartCoroutine(EndCutscene08());
    }

     private IEnumerator StartCutscene08()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene08.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene08();
    }

    private IEnumerator EndCutscene08()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene08.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene09()
    {
        Cutscene09.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene09());
    }

    public void DeactivateCutscene09()
    {
        StartCoroutine(EndCutscene09());
    }

     private IEnumerator StartCutscene09()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene09.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene09();
    }

    private IEnumerator EndCutscene09()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene09.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene10()
    {
        Cutscene10.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene10());
    }
    public void DeactivateCutscene10()
    {
        StartCoroutine(EndCutscene10());
    }

     private IEnumerator StartCutscene10()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene10.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene10();
    }

    private IEnumerator EndCutscene10()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene10.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
    public void Playcutscene11()
    {
        Cutscene11.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene11());
    }

    public void DeactivateCutscene11()
    {
        StartCoroutine(EndCutscene11());
    }

     private IEnumerator StartCutscene11()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene11.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene11();
    }

    private IEnumerator EndCutscene11()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene11.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene12()
    {
        Cutscene12.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene12());
    }

    public void DeactivateCutscene12()
    {
        StartCoroutine(EndCutscene12());
    }

     private IEnumerator StartCutscene12()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene12.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene12();
    }

    private IEnumerator EndCutscene12()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene12.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }


    public void Playcutscene13()
    {
        Cutscene13.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene13());
    }

    public void DeactivateCutscene13()
    {
        StartCoroutine(EndCutscene13());
    }

     private IEnumerator StartCutscene13()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene13.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene13();
    }

    private IEnumerator EndCutscene13()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene13.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene14()
    {
        Cutscene14.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene14());
    }

    public void DeactivateCutscene14()
    {
        StartCoroutine(EndCutscene14());
    }

     private IEnumerator StartCutscene14()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene14.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene14();
    }

    private IEnumerator EndCutscene14()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene14.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene15()
    {
        Cutscene15.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene15());
    }

    public void DeactivateCutscene15()
    {
        StartCoroutine(EndCutscene15());
    }

     private IEnumerator StartCutscene15()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene15.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene15();
    }

    private IEnumerator EndCutscene15()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene15.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }


   

  


}
