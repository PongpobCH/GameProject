using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CutsceneManagerDayEp : MonoBehaviour
{
    
    public List<Animator> AnimationForCutscene;
    public List<GameObject> Cutscene;
  

    public int RowCheckingValue = 0;
    public float transitiontime =1f;
    public GameObject ClickNextTextbutton;
    public GameObject dialogBox;

    void Start()
    {
        
       SetAllcutsceneNotActive();
        
    }

    public void SetAllcutsceneNotActive()
    {
        
       for(int i = 0; i < Cutscene.Count; i++)
        {
            Cutscene[i].SetActive(false);
        }
    }
    
    public void startEpilogue() {
        dialogBox.SetActive(false);
        StartCoroutine(StartCutscene(0));
    }

    private IEnumerator StartCutscene(int index)
    {
        Cutscene[index].SetActive(true);
        // Debug.Log("start Cutscene");
        AnimationForCutscene[index].SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime + 3f);
        //Debug.Log("CutSceneEnded");
        AnimationForCutscene[index].SetTrigger("End");
        if (index+1 < Cutscene.Count) { StartCoroutine(StartCutscene(index + 1)); }
        else { SceneManager.LoadScene(0); }
    }

}
