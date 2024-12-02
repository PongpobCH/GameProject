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

    public void LoadtoEvaroom() 
    {
        //Debug.Log("Hit");
        StartCoroutine(LoadtoEvaRoom());
        gamesavedvaluescript.IncrementLoadtimes();

    }


    IEnumerator LoadtoEvaRoom()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Prologue");
        
    }

    public void LoadDay1()
    {
         StartCoroutine(LoadtoDay1());
    }

    IEnumerator LoadtoDay1()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Day1");
        
    }

     public void loadminigamepetting()
    {
         StartCoroutine(Loadminigame1());
    }

    IEnumerator Loadminigame1()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Minigame_Petting");
        
    }

    public void loadminigamesymtom()
    {
         StartCoroutine(Loadminigame2());
    }

    IEnumerator Loadminigame2()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Minigame_Symtom");
        
    }

    public void loadday2()
    {
         StartCoroutine(Loadtoday2());
    }

    IEnumerator Loadtoday2()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Day2");
        
    }

    public void loadday3()
    {
         StartCoroutine(Loadtoday3());
    }

    IEnumerator Loadtoday3()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Day3");
        
    }

    public void loadday4()
    {
         StartCoroutine(Loadtoday4());
    }

    IEnumerator Loadtoday4()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Day4");
        
    }

     public void loadday5()
    {
         StartCoroutine(Loadtoday5());
    }

    IEnumerator Loadtoday5()
    {
        //Debug.Log("Loadscene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene("Day4");
        
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



