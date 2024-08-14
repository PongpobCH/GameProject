using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.ShaderGraph.Internal;
using System.Data.Common;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;
using System;
using System.Threading;

public class readexcel : MonoBehaviour
{

    public TextAsset textAssetdata; 


    private string Text;

    public TextMeshProUGUI Dialogue;
    public TextMeshProUGUI Name;

    private int dialogue = 0;

    private int Charaname = 0;

    private int i = 0;

    private int count = 0;

    
    
    // Start is called before the first frame update
    void Start()
    {
        string[] data = textAssetdata.text.Split(new string[]{"," , "\n"},System.StringSplitOptions.None);

        
            
               Dialogue.text = data[dialogue+1];

               Name.text = data[Charaname];

            //Debug.Log("dialogueID = " + dialogue);
            //Debug.Log("characterID = " + Charaname);
             Debug.Log("datalength = " + data.Length);
            

            count ++;
            count ++;

            Debug.Log("Counts = " + count);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Search()
    {

       

      
    }

    public void DisplaynextText()


    {
       
            string[] data = textAssetdata.text.Split(new string[]{"," , "\n"},System.StringSplitOptions.None);


           if (i == 0)
           {


            Name.text = data[Charaname++];
            Name.text = data[Charaname++];
            Name.text = data[Charaname++];

            Dialogue.text = data[dialogue++];
            Dialogue.text = data[dialogue++];
            Dialogue.text = data[dialogue++];
            Dialogue.text = data[dialogue++];
  
               i++;

            count++;
            count++;

            //Debug.Log("Count = " + count);          
            
           }

           else if ( count == data.Length)
            {
                
                Debug.Log("Finished");
                Debug.Log("Count = " + count);


            }

            else

                {

                    Name.text = data[Charaname++];
                    Name.text = data[Charaname++];

                    Dialogue.text = data[dialogue++];
                    Dialogue.text = data[dialogue++];                 

                    count ++;
                    count ++;
                    Debug.Log("count = " + count);

                }

           
           
            
           

                


            

        
           

            

            
            
            

    }
}
