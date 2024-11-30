using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CutsceneManagerDay02 : MonoBehaviour
{
    public Animator AnimationForCutscene01;
    public Animator AnimationForCutscene02;
    public Animator AnimationForCutscene03;
    public Animator AnimationForCutscene04;
    public Animator AnimationForCutscene05;
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
    public Animator AnimationForCutscene16;
    public Animator AnimationForCutscene17;
    public Animator AnimationForCutscene18;
    public Animator AnimationForCutscene19;
    public Animator AnimationForCutscene20;
    public Animator AnimationForCutscene21;
    public Animator AnimationForCutscene22;
    public Animator AnimationForCutscene23;
    public Animator AnimationForCutscene24;
    public Animator AnimationForCutscene25;
    public Animator AnimationForCutscene26;
    public Animator AnimationForCutscene27;
    public Animator AnimationForCutscene28;
    public Animator AnimationForCutscene29;
    public Animator AnimationForCutscene30;
    public Animator AnimationForCutscene31;
    public Animator AnimationForCutscene32;
    public Animator AnimationForCutscene33;
    public Animator AnimationForCutscene34;    
    public GameObject Cutscene01;
    public GameObject Cutscene02;
    public GameObject Cutscene03;
    public GameObject Cutscene04;
    public GameObject Cutscene05;
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
    public GameObject Cutscene16;
    public GameObject Cutscene17;
    public GameObject Cutscene18;
    public GameObject Cutscene19;
    public GameObject Cutscene20;
    public GameObject Cutscene21;
    public GameObject Cutscene22;
    public GameObject Cutscene23;
    public GameObject Cutscene24;
    public GameObject Cutscene25;
    public GameObject Cutscene26;
    public GameObject Cutscene27;
    public GameObject Cutscene28;
    public GameObject Cutscene29;
    public GameObject Cutscene30;
    public GameObject Cutscene31;
    public GameObject Cutscene32;
    public GameObject Cutscene33;
    public GameObject Cutscene34;

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
        Cutscene07.SetActive(false);
        Cutscene08.SetActive(false);
        Cutscene09.SetActive(false);
        Cutscene10.SetActive(false);
        Cutscene11.SetActive(false);
        Cutscene12.SetActive(false);
        Cutscene13.SetActive(false);
        Cutscene14.SetActive(false);
        Cutscene15.SetActive(false);
        Cutscene16.SetActive(false);
        Cutscene17.SetActive(false);
        Cutscene18.SetActive(false);
        Cutscene19.SetActive(false);
        Cutscene20.SetActive(false);
        Cutscene21.SetActive(false);
        Cutscene22.SetActive(false);
        Cutscene23.SetActive(false);
        Cutscene24.SetActive(false);
        Cutscene25.SetActive(false);
        Cutscene26.SetActive(false);
        Cutscene27.SetActive(false);
        Cutscene28.SetActive(false);
        Cutscene29.SetActive(false);
        Cutscene30.SetActive(false);
        Cutscene31.SetActive(false);
        Cutscene32.SetActive(false);
        Cutscene33.SetActive(false);
        Cutscene34.SetActive(false);
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

    public void Playcutscene16()
    {
        Cutscene16.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene16());
    }

    public void DeactivateCutscene16()
    {
        StartCoroutine(EndCutscene16());
    }

     private IEnumerator StartCutscene16()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene16.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene16();
    }

    private IEnumerator EndCutscene16()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene16.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
    public void Playcutscene17()
    {
        Cutscene17.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene17());
    }

    public void DeactivateCutscene17()
    {
        StartCoroutine(EndCutscene17());
    }

     private IEnumerator StartCutscene17()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene17.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene17();
    }

    private IEnumerator EndCutscene17()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene17.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
    public void Playcutscene18()
    {
        Cutscene18.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene18());
    }

    public void DeactivateCutscene18()
    {
        StartCoroutine(EndCutscene18());
    }

     private IEnumerator StartCutscene18()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene18.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene18();
    }

    private IEnumerator EndCutscene18()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene18.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene19()
    {
        Cutscene19.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene19());
    }

    public void DeactivateCutscene19()
    {
        StartCoroutine(EndCutscene19());
    }

     private IEnumerator StartCutscene19()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene19.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene19();
    }

    private IEnumerator EndCutscene19()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene19.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene20()
    {
        Cutscene20.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene20());
    }

    public void DeactivateCutscene20()
    {
        StartCoroutine(EndCutscene20());
    }

     private IEnumerator StartCutscene20()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene20.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene20();
    }

    private IEnumerator EndCutscene20()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene20.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene21()
    {
        Cutscene21.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene21());
    }

    public void DeactivateCutscene21()
    {
        StartCoroutine(EndCutscene21());
    }

     private IEnumerator StartCutscene21()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene21.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene21();
    }

    private IEnumerator EndCutscene21()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene21.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene22()
    {
        Cutscene22.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene22());
    }

    public void DeactivateCutscene22()
    {
        StartCoroutine(EndCutscene22());
    }

     private IEnumerator StartCutscene22()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene22.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene22();
    }

    private IEnumerator EndCutscene22()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene22.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
    public void Playcutscene23()
    {
        Cutscene23.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene23());
    }

    public void DeactivateCutscene23()
    {
        StartCoroutine(EndCutscene23());
    }

     private IEnumerator StartCutscene23()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene23.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene23();
    }

    private IEnumerator EndCutscene23()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene23.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene24()
    {
        Cutscene24.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene24());
    }

    public void DeactivateCutscene24()
    {
        StartCoroutine(EndCutscene24());
    }

     private IEnumerator StartCutscene24()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene24.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene24();
    }

    private IEnumerator EndCutscene24()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene24.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene25()
    {
        Cutscene25.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene25());
    }

    public void DeactivateCutscene25()
    {
        StartCoroutine(EndCutscene25());
    }

     private IEnumerator StartCutscene25()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene25.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene25();
    }

    private IEnumerator EndCutscene25()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene25.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene26()
    {
        Cutscene26.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene26());
    }

    public void DeactivateCutscene26()
    {
        StartCoroutine(EndCutscene26());
    }

     private IEnumerator StartCutscene26()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene26.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene26();
    }

    private IEnumerator EndCutscene26()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene26.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene27()
    {
        Cutscene27.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene27());
    }

    public void DeactivateCutscene27()
    {
        StartCoroutine(EndCutscene27());
    }

     private IEnumerator StartCutscene27()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene27.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene27();
    }

    private IEnumerator EndCutscene27()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene27.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene28()
    {
        Cutscene28.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene28());
    }

    public void DeactivateCutscene28()
    {
        StartCoroutine(EndCutscene28());
    }

     private IEnumerator StartCutscene28()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene28.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene28();
    }

    private IEnumerator EndCutscene28()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene28.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene29()
    {
        Cutscene29.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene29());
    }

    public void DeactivateCutscene29()
    {
        StartCoroutine(EndCutscene29());
    }

     private IEnumerator StartCutscene29()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene29.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene29();
    }

    private IEnumerator EndCutscene29()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene29.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene30()
    {
        Cutscene30.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene30());
    }

    public void DeactivateCutscene30()
    {
        StartCoroutine(EndCutscene30());
    }

     private IEnumerator StartCutscene30()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene30.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene30();
    }

    private IEnumerator EndCutscene30()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene30.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene31()
    {
        Cutscene31.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene31());
    }

    public void DeactivateCutscene31()
    {
        StartCoroutine(EndCutscene31());
    }

     private IEnumerator StartCutscene31()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene31.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene31();
    }

    private IEnumerator EndCutscene31()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene31.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene32()
    {
        Cutscene32.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene32());
    }

    public void DeactivateCutscene32()
    {
        StartCoroutine(EndCutscene32());
    }

     private IEnumerator StartCutscene32()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene32.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene32();
    }

    private IEnumerator EndCutscene32()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene32.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene33()
    {
        Cutscene33.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene33());
    }

    public void DeactivateCutscene33()
    {
        StartCoroutine(EndCutscene33());
    }

     private IEnumerator StartCutscene33()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene33.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene33();
    }

    private IEnumerator EndCutscene33()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene33.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }

    public void Playcutscene34()
    {
        Cutscene33.SetActive(true);
        ClickNextTextbutton.SetActive(false);
        StartCoroutine(StartCutscene34());
    }

    public void DeactivateCutscene34()
    {
        StartCoroutine(EndCutscene34());
    }

     private IEnumerator StartCutscene34()
    {
       // Debug.Log("start Cutscene");
        AnimationForCutscene34.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        //Debug.Log("CutSceneEnded");
        DeactivateCutscene34();
    }

    private IEnumerator EndCutscene34()
    {
        //Debug.Log("CutSceneEnded");
         AnimationForCutscene34.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime);
         ClickNextTextbutton.SetActive(true);

    }
     

}
