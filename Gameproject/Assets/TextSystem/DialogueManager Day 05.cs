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

public class DialogManagerDay05 : MonoBehaviour
{
    
    public TextAsset textAssetdata; 
    public ChangeScene scenescript;
    public LevelLoader loadlevelscript;
    //public choicemanagerday4 choicemanagerscript;
    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public GameObject CharacterImageRed; // Load "Red" Character Sprite
    public GameObject UserInterface;
    public GameObject ContinueButton;
    public GameObject ParkBG;
    public GameObject AvaRoom;
    public GameObject Classroom;
    //public GameObject BlackBG;
    public GameObject Phycologitsroom;
    public GameObject BG;
    public GameObject cutscenesblackscreen;
    public GameObject dialogUI;
    public blackscreen scriptcutscene;
    //public blackscreen blackbg;
    public CutsceneManagerday5 scriptcutsceneManager;
    public int Loadtimes;
    public int LoadRow;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 2; // คอลัมน์ที่เก็บชื่อ Sprite
    //private int columnScene = 2; //เก็บ Active Scene
   

    void Start()
    {
        //BlackBG.SetActive(false);
        cutscenesblackscreen.gameObject.SetActive(false);
        UserInterface.gameObject.SetActive(true);   //ไว้ปิดตัว Dialog 

        Loadtimes = GameManager2.Instance.Loadtimes;

            if (Loadtimes == 0)
            {
                //Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = 0;
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

                LoadRow = 0;
                
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
            //UserInterface.gameObject.SetActive(false);
            GameManager2.Instance.RowData = 0; GameManager2.Instance.SavedRow();
            ContinueButton.SetActive(false);
            loadlevelscript.LoadDayEP();
            return;

        }

            //dialogUI.SetActive(true);
            //Dialog.gameObject.SetActive(true);
            //Debug.Log("Next Dialog");

            
            // แสดงชื่อและข้อความ
            Name.text = data[GameManager2.Instance.RowData * 3 + columnName];
            Dialog.text = data[GameManager2.Instance.RowData * 3 + columnDialogue];

            // โหลดและแสดง sprite

            LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 3 + columnSprite]);

            GameManager2.Instance.SavedRow();   



        if(GameManager2.Instance.RowData == 5) // open cutscenes25
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene01();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

       if(GameManager2.Instance.RowData == 12) // open cutscenes26
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene02();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

       if(GameManager2.Instance.RowData == 15){

          AvaRoom.SetActive(false);
          Phycologitsroom.SetActive(true);
       }

        if(GameManager2.Instance.RowData == 46){

            AvaRoom.SetActive(true);
            Phycologitsroom.SetActive(false);
        }

       

       if(GameManager2.Instance.RowData == 37) // open cutscenes27
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene03();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }

       if(GameManager2.Instance.RowData == 65) // open cutscenes28
       {
            ContinueButton.SetActive(false);

            cutscenesblackscreen.gameObject.SetActive(true);
          scriptcutsceneManager.Playcutscene04();
          scriptcutscene.ActivateCutscene();
          Invoke("EndCutscenebackground", 5);

       }
       


       
    }
    private void Changescnenetopark () 
    {
       ParkBG.SetActive(true);
       AvaRoom.SetActive(false);
    }
    private void Changescenetoclassroom()
    {
         ParkBG.SetActive(false);
         AvaRoom.SetActive(false);
         Classroom.SetActive(true);
    }
    private void changescenetoblack(){

         //BlackBG.SetActive(true);
         //blackbg.ActivateCutscene();

    }
    private void closeclassroom(){

         Classroom.SetActive(false);
         BG.SetActive(true);
    }
    private void changescenetoAvaroom()
    {
         BG.SetActive(false);
         AvaRoom.SetActive(true);
         Classroom.SetActive(false);
    }
    
   

    private void EndCutscenebackground()
    {
        ContinueButton.SetActive(true);

        cutscenesblackscreen.gameObject.SetActive(false);
        //BlackBG.gameObject.SetActive(false);
    }

    

    private void LoadAndDisplaySprite(string spriteName)
    {
        //spriteName = spriteName.Remove(spriteName.Length-1);
        string folderPath = "Sprites/Characters/";
        string keywordred = "red"; // Load Only Red Keyword
        string keywordava = "ava"; // Load Only Ava Keyword
        string keywordpsy = "therapist"; 
       


        if(spriteName.Contains(keywordred))
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

        if(spriteName.Contains(keywordpsy))
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
