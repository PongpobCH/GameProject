using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutsceneopen : MonoBehaviour
{


     public Animator transition;

     public float transitiontime =1f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void ActivateCutscene()
    {
         StartCoroutine(StartCutscene());
    }
    public void DeactivateCutscene()
    {
        StartCoroutine(EndCutscene());
    }

    private IEnumerator StartCutscene()

    {
        
        Debug.Log("start Cutscene");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitiontime+3f);
        Debug.Log("CutSceneEnded");
        DeactivateCutscene();
        
        
        
    }
    private IEnumerator EndCutscene()
    {
        Debug.Log("CutSceneEnded");
         transition.SetTrigger("End");
         yield return new WaitForSeconds(transitiontime+3f);

    }

}
