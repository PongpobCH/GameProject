using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public Animator AnimationForCutscene01; 
    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    public GameObject Cutscene01;
    public GameObject Cutscene02;

    

    void Start()
    {
    
        Cutscene01.SetActive(false);
        Cutscene02.SetActive(false);

    }
    public void CheckRow()

    {
        RowCheckingValue = GameManager2.Instance.RowData;
        Debug.Log("Row Checked from Server " + RowCheckingValue);
    }

     public void DeactivateCutscene()
    {
        StartCoroutine(EndCutscene());
    }

    public void Playcutscene01()
    {
        Cutscene01.SetActive(true);
        StartCoroutine(StartCutscene01());
    }

    public void Playcutscene02()
    {
        //Cutscene02.SetActive(true);
        //StartCoroutine(StartCutscene01());
    }

    private IEnumerator StartCutscene01()
    {
        Debug.Log("start Cutscene");
        AnimationForCutscene01.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        Debug.Log("CutSceneEnded");
        DeactivateCutscene();
    }

    private IEnumerator EndCutscene()
    {
        Debug.Log("CutSceneEnded");
         AnimationForCutscene01.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime+3f);

    }



     

}
