using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEditor.Search;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class DialogManager : MonoBehaviour
{
    
    public TextAsset textAssetdata; 
    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public GameObject CharacterImageRed; // Load "Red" Character Sprite
    public GameObject CharacterImageUC;
    public GameObject Choicemenu;
    public GameObject UserInterface;
    //public GameObject cutscenes01;
    

    public GameObject cutscenesblackscreen;
    public blackscreen scriptcutscene;
    public CutsceneManager scriptcutsceneManager;

    public int Loadtimes;
    public int LoadRow;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 2; // คอลัมน์ที่เก็บชื่อ Sprite
    //private int columnScene = 2; //เก็บ Active Scene
    private bool ischoice = false;
   

    void Start()
    {

        cutscenesblackscreen.gameObject.SetActive(false);
        //cutscenes01.gameObject.SetActive(false);    //ไว้ปิด Cutscene01
        
        Choicemenu.gameObject.SetActive(false);     //ไว้ปิดตัว Choice 
        UserInterface.gameObject.SetActive(true);   //ไว้ปิดตัว Dialog 

        Loadtimes = GameManager2.Instance.Loadtimes;

            if (Loadtimes == 0)
            {
                //Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData;

                //Debug.Log("LoadSavedRow = " + GameManager2.Instance.RowData);

                string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

                // แสดงข้อความและชื่อ
                Name.text = data[LoadRow * 3 + columnName];
                Dialog.text = data[LoadRow * 3 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 3 + columnSprite]);                
                GameManager2.Instance.SavedRow();

            }
           else 
           {

                //Debug.Log("Load 2 or more times "); ไว้ Test debug โหลดครั้งที่ 2 

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData - 1;
                
                string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
                
                Debug.Log("LoadSavedrow = " + GameManager2.Instance.RowData);

                // แสดงข้อความและชื่อ
                Name.text = data[LoadRow * 3 + columnName];
                Dialog.text = data[LoadRow * 3 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 3 + columnSprite]);

           }

           scriptcutsceneManager.CheckRow();
           
            
           
    }

    public void DisplaynextText() // Show Next Text
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        //Debug.Log("Current Load Row = " + GameManager2.Instance.RowData);
        //LoadRow = GameManager2.Instance.RowData;

        
        if (GameManager2.Instance.RowData >= data.Length / 3) //Dialog จบแล้ว
        {
            Debug.Log("End of Dialog");
            UserInterface.gameObject.SetActive(false);
            //SceneManager.LoadScene("TestScene1"); 
            return;

            
        }

             // แสดงชื่อและข้อความ
                Name.text = data[GameManager2.Instance.RowData * 3 + columnName];
                Dialog.text = data[GameManager2.Instance.RowData * 3 + columnDialogue];

             // โหลดและแสดง sprite

                LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 3 + columnSprite]);

                GameManager2.Instance.SavedRow();


        if(ischoice == false)
        {

                if (GameManager2.Instance.RowData == 200) // test Choice 
            {
                Debug.Log("Activate Choice");
                Choicemenu.gameObject.SetActive(true);
                ischoice = true;

            }

        }

        if(GameManager2.Instance.RowData == 4) // open cutscenes01
        {
            cutscenesblackscreen.gameObject.SetActive(true);
           
            scriptcutsceneManager.Playcutscene01();
            scriptcutscene.ActivateCutscene();
            
            
            Invoke("EndCutscenebackground", 3);

        }

        if(GameManager2.Instance.RowData == 7) // open cutscenes01
        {

             cutscenesblackscreen.gameObject.SetActive(true);
           
            scriptcutsceneManager.Playcutscene02();
            
            Invoke("EndCutscenebackground", 3);



        }

       
               
    }

    private void EndCutscenebackground()
    {
        
        cutscenesblackscreen.gameObject.SetActive(false);
    }

    

    private void LoadAndDisplaySprite(string spriteName)
    {
        //spriteName = spriteName.Remove(spriteName.Length-1);
        string folderPath = "Sprites/Characters/";
        string keywordred = "red"; // Load Only Red Keyword
        string keywordeve = "ava"; // Load Only Eve Keyword
       


        if(spriteName.Contains(keywordred))
        {
            Sprite sprite = Resources.Load<Sprite>(folderPath+spriteName);
            CharacterImage.gameObject.SetActive(false);

             // ถ้าพบ sprite ที่มีชื่อตรงกัน จะแสดงผลใน Image ที่กำหนด
            if (sprite != null)
            {
                CharacterImageRed.gameObject.SetActive(true);
                CharacterImageRed.GetComponent<SpriteRenderer>().sprite = sprite;
            }
            else
            {
                Debug.LogWarning("Sprite not found: " + folderPath + spriteName);
            }
        }
        
        if(spriteName.Contains(keywordeve))
        {
            Sprite sprite = Resources.Load<Sprite>(folderPath+spriteName);
            CharacterImageRed.gameObject.SetActive(false);

             // ถ้าพบ sprite ที่มีชื่อตรงกัน จะแสดงผลใน Image ที่กำหนด
            if (sprite != null)
            {   
                CharacterImage.gameObject.SetActive(true);
                CharacterImage.GetComponent<SpriteRenderer>().sprite = sprite;
            }
            else
            {
                Debug.LogWarning("Sprite not found: " + folderPath + spriteName);
            }

            
        } 

       


    }
    public void Choice1() //เลือก Choice 1
    {

        Debug.Log("Choice 1");
        Choicemenu.gameObject.SetActive(false);
        ischoice = true;
        Debug.Log(ischoice);
        
        DisplaynextText();


    }
    public void Choice2() //เลือก Choice 2
    {
        Debug.Log("Choice 2");
        Choicemenu.gameObject.SetActive(false);
         ischoice = true;
         Debug.Log(ischoice);
         
         DisplaynextText();
    }
    public void Choice3() //เลือก Choice 3
    {
        Debug.Log("Choice 3");
        Choicemenu.gameObject.SetActive(false);
         ischoice = true;
         Debug.Log(ischoice);
        
         DisplaynextText();
    }
}
