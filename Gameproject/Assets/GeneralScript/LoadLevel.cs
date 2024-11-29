using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    public Animator transition;

    public float transitiontime =1f;
    public bool isRedDiaryCollected = false;

    public GameManager2 gamesavedvaluescript;
    public EntityChecker EntityCheckerscript;

    // Update is called once per frame

    public void LoadtoPrologue() 
    {
        //Debug.Log("Hit");
        StartCoroutine(LoadPrologue());
        gamesavedvaluescript.IncrementLoadtimes();

    }


    IEnumerator LoadPrologue ()
    {
        Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Prologue");
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           //LoadPrologue();
           if(EntityCheckerscript.isRedDiaryCollected == true)
           {
                 LoadtoPrologue();
           }
           
           Debug.Log("No red Diary");
          
        }
    }

}



