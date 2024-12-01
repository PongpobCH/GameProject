using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Rendering;
using UnityEngine;

public class choicemanager : MonoBehaviour
{
   
    public GameObject choiceUI01;
    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject DialogUI;
    public GameObject ContinueButton;
    public GameObject ChoiceUI02; 

    public GameObject AnswerA2;
    public GameObject AnswerB2;
    public GameObject AnswerC2;
    

   
    void Start()
    {
        choiceUI01.SetActive(false);
        ChoiceUI02.SetActive(false);
        
    }

    public void checkforchoice(){
        if(GameManager2.Instance.RowData == 71 )
        {
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }

        if(GameManager2.Instance.RowData == 145){
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }
    }

    public void SelectedAnswerA(){

        //Debug.Log("AnswerA");
        AnswerA.SetActive(true);
        choiceUI01.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

        
    }
    public void SelectedAnswerB(){

        //Debug.Log("AnswerB");
        AnswerB.SetActive(true);
        choiceUI01.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
    }

    public void SelectedAnswerA1(){

        AnswerA.SetActive(true);
        choiceUI01.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
        GameManager2.Instance.RowData = 150;
    }
    public void SelectedAnswerB1(){

        AnswerB.SetActive(true);
        choiceUI01.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
        GameManager2.Instance.RowData = 150;
    }

    public void checkforchoice02 (){

       if(GameManager2.Instance.RowData == 85 ){

            ChoiceUI02.SetActive(true);
            ContinueButton.SetActive(false);

       }
    }
    public void selectedAnswerA2()
    {
        //Debug.Log("A2");
        //AnswerA2.SetActive(true);
        ChoiceUI02.SetActive(false);
        //DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

    }
    public void selectedAnswerB2(){
        //Debug.Log("B2"); 
         //AnswerB2.SetActive(true);
        ChoiceUI02.SetActive(false);
        //DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

    }

    public void selectedAnswerC2(){
        //Debug.Log("C2"); 
        //AnswerC2.SetActive(true);
        ChoiceUI02.SetActive(false);
        //DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

    }

    

}
