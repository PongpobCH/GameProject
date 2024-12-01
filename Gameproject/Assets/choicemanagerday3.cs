using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using JetBrains.Annotations;
using UnityEditor.Rendering;
using UnityEngine;

public class choicemanagerday3 : MonoBehaviour
{
   
    public GameObject choiceUI01;
    public GameObject choice2;
    public GameObject choice2set1;
    public GameObject choice2set2;
    public GameObject choiceB;
    public GameObject choiceC;
    public GameObject choiceC3;

    public GameObject AnswerSet1;
    public GameObject AnswerSet2;
    public GameObject AnswerSet3;
    public GameObject AnswerSetC;
    public GameObject AnswerA1;
    public GameObject AnswerA2;
    public GameObject AnswerA21;
    public GameObject AnswerA22;
    public GameObject AnswerA23;
    public GameObject AnswerA3;
    public GameObject AnswerA11;
    public GameObject AnswerA111;
    public GameObject AnswerC1;
    public GameObject AnswerC2;
    public GameObject AnswerC3;
    public GameObject AnswerB01;

    public GameObject DialogUI;
    public GameObject ContinueButton;
    //public GameObject ChoiceUI02; 

    //public GameObject AnswerA2;
    public bool isselectbag = false;
    public bool isselectC = false;
    

   
    void Start()
    {
        choiceUI01.SetActive(false);
        choice2.SetActive(false);
        choice2set1.SetActive(false);
        choice2set2.SetActive(false);
        choiceB.SetActive(false);
        choiceC.SetActive(false);
        choiceC3.SetActive(false);
        
    }

    public void checkforchoice(){

        if(GameManager2.Instance.RowData == 192 )
        {
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }

        if(GameManager2.Instance.RowData == 194){

            if (isselectbag == true ){

                choice2set1.SetActive(true);    
                ContinueButton.SetActive(false);
                return;


            }
            if (isselectC == true ){

                choiceC.SetActive(true);
                ContinueButton.SetActive(false);

                return;
            }
            choice2.SetActive(true);
            ContinueButton.SetActive(false);
        }

        if(GameManager2.Instance.RowData == 196){
            
            if (isselectbag == true ){

                choiceB.SetActive(true);
                ContinueButton.SetActive(false);
                return;

            }
            if (isselectC == true ){

                choiceC.SetActive(true);
                ContinueButton.SetActive(false);
                return;
            }
            choice2set2.SetActive(true);
            ContinueButton.SetActive(false);
        }
       if(GameManager2.Instance.RowData == 195){
           
           if (isselectbag == true ){
            closeanswerset2();
            DialogUI.SetActive(true);
            return;
       }
           if (isselectC == true ){
                closeanswersetC();
                DialogUI.SetActive(true);
                return;
           }
            closeanswerset1();
            DialogUI.SetActive(true);
       }
       if(GameManager2.Instance.RowData == 197){

            if (isselectbag == true ){

                AnswerB01.SetActive(false);
                DialogUI.SetActive(true);
            
                return;
            }

            if (isselectC == true ){
                //AnswerC1.SetActive(false);
            }
                closeanswerset2();
                DialogUI.SetActive(true);
       }
       if (GameManager2.Instance.RowData == 202){

            if (isselectbag == true ){
                GameManager2.Instance.RowData = 203;
                DialogUI.SetActive(true);
                return;
        }
         if (isselectC == true ){

                GameManager2.Instance.RowData = 203;
                DialogUI.SetActive(true);
                return;

           }
            AnswerA111.SetActive(true);
            DialogUI.SetActive(false);
       }
        if (GameManager2.Instance.RowData == 203){

            if (isselectbag == true ){
                AnswerB01.SetActive(false);
                DialogUI.SetActive(true);
            return;
       }
            AnswerA111.SetActive(false);
            DialogUI.SetActive(true);
       }

    }

    public void SelectedAnswerA(){

        //Debug.Log("AnswerA");
        //AnswerA.SetActive(true);
        choiceUI01.SetActive(false);
        //DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

        
    }
    public void SelectedAnswerB(){

        //Debug.Log("AnswerB");
        //AnswerB.SetActive(true);
        choiceUI01.SetActive(false);
        isselectbag = true;
        //DialogUI.SetActive(false);
        ContinueButton.SetActive(true);


    }
    public void SelectedAnswerC(){
        //AnswerC.SetActive(true);
        isselectC = true;
        choiceUI01.SetActive(false);
        ContinueButton.SetActive(true);
        
    }

    public void SelectedAnswerA21(){

        AnswerA1.SetActive(true);
        choice2.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
        
    }
    public void SelectedAnswerB21(){

        AnswerA2.SetActive(true);
        choice2.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
       
    }
    public void SelectedAnswerC21(){

        AnswerA3.SetActive(true);
        choice2.SetActive(false);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
       
    }
    public void selectedAnswerA22()
    {
        choice2set1.SetActive(false);
        ContinueButton.SetActive(true);

    }
    public void selectedAnswerB22(){
        
        choice2set1.SetActive(false);
        ContinueButton.SetActive(true);

    }

    public void selectedAnswerC22(){
        choice2set1.SetActive(false);
        ContinueButton.SetActive(true);

    }

    public void selectedAnswerA23()
    {
        AnswerA11.SetActive(true);
        choice2set2.SetActive(false);
        ContinueButton.SetActive(true);
        DialogUI.SetActive(false);

    }
    public void selectedAnswerB23(){
        
        AnswerA11.SetActive(true);
        choice2set2.SetActive(false);
        ContinueButton.SetActive(true);
        DialogUI.SetActive(false);

    }

    public void selectAnswerA21(){

        choice2set1.SetActive(false);
        AnswerA21.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
       
    }

    public void selectAnswerA22(){

        choice2set1.SetActive(false);
        AnswerA22.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
       
    }

     public void selectAnswerA23(){

        choice2set1.SetActive(false);
        AnswerA23.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
       
    }

    public void AnswerB1(){

        choiceB.SetActive(false);
       AnswerB01.SetActive(true);
       ContinueButton.SetActive(true);
       DialogUI.SetActive(false);

    }

    public void AnswerC01(){

        choiceC.SetActive(false);
        AnswerC1.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

    }
    public void AnswerC02(){

        choiceC.SetActive(false);
        AnswerC2.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);

    }

    public void AnswerC03(){

        choiceC.SetActive(false);
        AnswerC3.SetActive(true);
        DialogUI.SetActive(false);
        ContinueButton.SetActive(true);
        
    }


    











    public void closeanswerset1(){
        AnswerSet1.SetActive(false);
    }
    public void closeanswerset2(){
        AnswerSet2.SetActive(false);
    }
    public void closeanswerset3(){
        AnswerSet3.SetActive(false);
    }

   public void closeanswersetC(){
        AnswerSetC.SetActive(false);
   }

    

}
