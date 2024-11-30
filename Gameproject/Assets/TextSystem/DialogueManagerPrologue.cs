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

public class DialogManagerPrologue: MonoBehaviour
{
    public blackscreen scriptcutscene;
    public CutsceneManagerPrologue scriptcutsceneManager;
    public ChangeScene scenescript;
    public TextAsset textAssetdata; 
    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public GameObject CharacterImageRed; // Load "Red" Character Sprite
    public GameObject CharacterImageUC;
    public GameObject Choicemenu01;
    public GameObject UserInterface;
    public GameObject ContinueButton;
    public GameObject cutscenesblackscreen;
    public GameObject EvaRoomBackground;
    public GameObject Parkbackground;
   
    public GameObject ChoiceSet01ASelected;
    public GameObject ChoiceSet01BSelected;
    public GameObject AvaName;
    public GameObject RedName;

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
        ChoiceSet01ASelected.gameObject.SetActive(false);
        ChoiceSet01BSelected.gameObject.SetActive(false);
        AvaName.gameObject.SetActive(false);
        RedName.gameObject.SetActive(false);
        cutscenesblackscreen.gameObject.SetActive(false);
        Choicemenu01.gameObject.SetActive(false);     //ไว้ปิดตัว Choice 
        UserInterface.gameObject.SetActive(true);   //ไว้ปิดตัว Dialog 

        
        Parkbackground.SetActive(true);
        EvaRoomBackground.SetActive(false);

        Loadtimes = GameManager2.Instance.Loadtimes;

            if (Loadtimes == 0)
            {
                //Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;
                GameManager2.Instance.LoadAvaroomtimes++;

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

                Parkbackground.SetActive(false);

                EvaRoomBackground.SetActive(true);
                
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

        AvaName.gameObject.SetActive(false);
        RedName.gameObject.SetActive(false);
        ChoiceSet01ASelected.gameObject.SetActive(false);
        ChoiceSet01BSelected.gameObject.SetActive(false);
        //Dialog.gameObject.SetActive(true);


        if (GameManager2.Instance.RowData >= data.Length / 3) //Dialog จบแล้ว
        {
            Debug.Log("End of Dialog");
            UserInterface.gameObject.SetActive(false);
            SceneManager.LoadScene("Day1"); 
            return;

        }

        
        if(ischoice == false)
        {

                if (GameManager2.Instance.RowData == 71) // ChoiceSet01
            {

                //Debug.Log("Activate Choice");
                Choicemenu01.gameObject.SetActive(true);
                ischoice = true;
                Name.gameObject.SetActive(false);
                ContinueButton.gameObject.SetActive(false);


            }

            AvaName.gameObject.SetActive(false);
            RedName.gameObject.SetActive(false);
            ChoiceSet01ASelected.gameObject.SetActive(false);
            ChoiceSet01BSelected.gameObject.SetActive(false);
            Dialog.gameObject.SetActive(true);
            // แสดงชื่อและข้อความ
            Name.text = data[GameManager2.Instance.RowData * 3 + columnName];
            Dialog.text = data[GameManager2.Instance.RowData * 3 + columnDialogue];

            // โหลดและแสดง sprite

            LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 3 + columnSprite]);

            GameManager2.Instance.SavedRow();   

        }



        if(GameManager2.Instance.RowData == 5) // open cutscenes01
        {
            cutscenesblackscreen.gameObject.SetActive(true);
           
            scriptcutsceneManager.Playcutscene01();
            scriptcutscene.ActivateCutscene();
            
            
            Invoke("EndCutscenebackground", 5);

        }

        if(GameManager2.Instance.RowData == 6) // Load into Park
        {
            
            Invoke("LoadParkScene", 3);

        } 

        
        
        
        if(GameManager2.Instance.RowData == 7) // open cutscenes02
        {

            cutscenesblackscreen.gameObject.SetActive(true);
           
            scriptcutsceneManager.Playcutscene02();
            
            
           
            Invoke("Cutscene02section2" ,5);

        }
        if(GameManager2.Instance.RowData == 8 ){
            scenescript.LoadAvaRoom();
        }  
       if(GameManager2.Instance.RowData == 9) // open cutscenes05
       {
          cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene05();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }
        if(GameManager2.Instance.RowData == 12) // open cutscenes06
       {
          cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene06();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }


    }

    private void LoadParkScene()
    {
         scenescript.LoadScenePark();
    }
        

       

       
       

    private void Cutscene02section2()
    {
        scriptcutsceneManager.Playcutscene03();
        Invoke("Cutscene02section3" , 5);

    }
    private void Cutscene02section3()
    {
        scriptcutsceneManager.Playcutscene04();
        scriptcutscene.ActivateCutscene();
        Invoke("EndCutscenebackground", 5);
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
        string keywordextra = "extra"; // Load Only Friend Keyword
       


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

        if(spriteName.Contains(keywordextra))
        {
            Sprite sprite = Resources.Load<Sprite>(folderPath+spriteName);
            CharacterImageRed.gameObject.SetActive(false);

             // ถ้าพบ sprite ที่มีชื่อตรงกัน จะแสดงผลใน Image ที่กำหนด
            if (sprite != null)
            {   
                Debug.Log("Showing Friend Sprite");
                CharacterImage.gameObject.SetActive(true);
                CharacterImage.GetComponent<SpriteRenderer>().sprite = sprite;
            }
            else
            {
                Debug.LogWarning("Sprite not found: " + folderPath + spriteName);
            }

            
        } 

       


    }
    public void SetAvaNameOn ()
    {
        AvaName.gameObject.SetActive(true);
    }
    public void SetRedNameOn()
    {
        RedName.gameObject.SetActive(true);
    }
    public void Choice01ASelection()
    {
        ChoiceSet01ASelected.gameObject.SetActive(true);
    }
    public void Choice01BSelection()
    {
        ChoiceSet01BSelected.gameObject.SetActive(true);
    }

    public void ChoiceSet1A() //เลือก Choice 1
    {

       
        Choicemenu01.gameObject.SetActive(false);
        ischoice = false;
        Dialog.gameObject.SetActive(false);
        SetAvaNameOn();
        Choice01ASelection();
        ContinueButton.gameObject.SetActive(true);


    }
    public void ChoiceSet1B() //เลือก Choice 2
    {
       
        Choicemenu01.gameObject.SetActive(false);
        ischoice = false;
        Dialog.gameObject.SetActive(false);
        SetRedNameOn();
        Choice01BSelection();
        ContinueButton.gameObject.SetActive(true);

    }
}
