using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class DialogManagerDay01 : MonoBehaviour
{
    
    public TextAsset textAssetdata; 
    public ChangeScene scenescript;
    public LevelLoader loadlevelscript;
    public choicemanager choicemanagerscript;
    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public GameObject CharacterImageRed; // Load "Red" Character Sprite
    public GameObject UserInterface;
    public GameObject ContinueButton;
    public GameObject ParkBG;
    public GameObject EvaRoom;
    public GameObject Classroom;
    public GameObject BlackBG;
    public GameObject BG;
    public GameObject cutscenesblackscreen;
    public GameObject dialogUI;
    public GameObject AnswerSet;
    public blackscreen scriptcutscene;
    public blackscreen blackbg;
    public CutsceneManagerDay01 scriptcutsceneManager;
    public int Loadtimes;
    public int LoadRow;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 2; // คอลัมน์ที่เก็บชื่อ Sprite
    //private int columnScene = 2; //เก็บ Active Scene
   

    void Start()
    {
        BlackBG.SetActive(false);
        cutscenesblackscreen.gameObject.SetActive(false);
        UserInterface.gameObject.SetActive(true);   //ไว้ปิดตัว Dialog 
        GameManager2.Instance.LoadAvaroomtimes = 1;
        Loadtimes = GameManager2.Instance.Loadtimes;

            if (Loadtimes == 0)
            {
                //Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData;
                //Debug.Log("LoadRow" + LoadRow);

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

        choicemanagerscript.checkforchoice();
      //  choicemanagerscript.checkforchoice02();

        //Debug.Log("Current Load Row = " + GameManager2.Instance.RowData);
        //LoadRow = GameManager2.Instance.RowData;


        if (GameManager2.Instance.RowData >= data.Length / 3) //Dialog จบแล้ว
        {
            Debug.Log("End of Dialog");
            //UserInterface.gameObject.SetActive(false);
            loadlevelscript.loadday2();
            GameManager2.Instance.RowData = 0; GameManager2.Instance.SavedRow();
            ContinueButton.SetActive(false);
            return;

        }

            dialogUI.SetActive(true);
            Dialog.gameObject.SetActive(true);

            if(GameManager2.Instance.RowData == 72)
            {
               AnswerSet.SetActive(false);
            } 
            // แสดงชื่อและข้อความ
            Name.text = data[GameManager2.Instance.RowData * 3 + columnName];
            Dialog.text = data[GameManager2.Instance.RowData * 3 + columnDialogue];

            // โหลดและแสดง sprite

            LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 3 + columnSprite]);

            GameManager2.Instance.SavedRow();

        if (GameManager2.Instance.RowData == 2) // open cutscenes07
        {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
            scriptcutsceneManager.Playcutscene06();
            scriptcutscene.ActivateCutscene();
            Invoke("EndCutscenebackground", 5);

        }

        if (GameManager2.Instance.RowData == 11) // open cutscenes07
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene07();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

       if(GameManager2.Instance.RowData == 13) // open cutscenes08
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene08();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

        if (GameManager2.Instance.RowData == 19) // change scene to park
        {
            Changescnenetopark();
        }

        if (GameManager2.Instance.RowData == 21) // open cutscenes09
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene09();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }
       

       if(GameManager2.Instance.RowData == 23) // open cutscenes10
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene10();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

       if(GameManager2.Instance.RowData == 26) // open cutscenes11
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene11();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

        if(GameManager2.Instance.RowData == 30) // open cutscenes12
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene12();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

     if(GameManager2.Instance.RowData == 41) // open cutscenes13
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene13();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

      if(GameManager2.Instance.RowData == 43) // Change to ClassRoom
      {
            Changescenetoclassroom();

      }
      if(GameManager2.Instance.RowData == 58)
      {
            ContinueButton.SetActive(false);

            changescenetoblack();
         Invoke("EndCutscenebackground", 5);
         Invoke("closeclassroom", 3 ); 
      } 
      if(GameManager2.Instance.RowData == 60)
      {
            ContinueButton.SetActive(false);

            changescenetoblack();
         Invoke("EndCutscenebackground", 5);
         Invoke("changescenetoAvaroom", 3);

      }

        if(GameManager2.Instance.RowData == 63) // open cutscenes14
       {
         scenescript.LoadAvaRoom();
       }

       if(GameManager2.Instance.RowData == 94) // open cutscenes15
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene15();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }
    }
    private void Changescnenetopark () 
    {
       ParkBG.SetActive(true);
       EvaRoom.SetActive(false);
    }
    private void Changescenetoclassroom()
    {
         ParkBG.SetActive(false);
         EvaRoom.SetActive(false);
         Classroom.SetActive(true);
    }
    private void changescenetoblack(){

         BlackBG.SetActive(true);
         blackbg.ActivateCutscene();

    }
    private void closeclassroom(){

         Classroom.SetActive(false);
         BG.SetActive(true);
    }
    private void changescenetoAvaroom()
    {
         BG.SetActive(false);
         EvaRoom.SetActive(true);
    }
    

    private void EndCutscenebackground()
    {
        
        cutscenesblackscreen.gameObject.SetActive(false);
        BlackBG.gameObject.SetActive(false);
        ContinueButton.SetActive(true);

    }



    private void LoadAndDisplaySprite(string spriteName)
    {
        //spriteName = spriteName.Remove(spriteName.Length-1);
        string folderPath = "Sprites/Characters/";
        string keywordred = "red"; // Load Only Red Keyword
        string keywordava = "ava"; // Load Only Ava Keyword
       


        if(spriteName.Contains(keywordred)|| spriteName.Contains("extra"))
        {
            Sprite sprite = Resources.Load<Sprite>((folderPath+spriteName).Trim());
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
        
        if(spriteName.Contains(keywordava))
        {
            Sprite sprite = Resources.Load<Sprite>((folderPath+spriteName).Trim());
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
    
}
