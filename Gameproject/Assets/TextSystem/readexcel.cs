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
    public GameObject Choicemenu;
    public GameObject UserInterface;
    public int Loadtimes;
    public int LoadRow;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 3; // คอลัมน์ที่เก็บชื่อ Sprite
    private int columnScene = 2; //เก็บ Active Scene
    private bool ischoice = false;


    void Start()
    {

        

       Choicemenu.gameObject.SetActive(false);
       UserInterface.gameObject.SetActive(false);

        Loadtimes = GameManager2.Instance.Loadtimes;

            if (Loadtimes == 0)
            {
                Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData;

                Debug.Log("LoadSavedRow = " + GameManager2.Instance.RowData);

                

                string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

                // แสดงข้อความและชื่อ
                Name.text = data[LoadRow * 4 + columnName];
                Dialog.text = data[LoadRow * 4 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 4 + columnSprite]);

                
                GameManager2.Instance.SavedRow();


            }
           else 
           {


                Debug.Log("Load 2 or more times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData - 1;
                
                string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
                
                Debug.Log("LoadSavedrow = " + GameManager2.Instance.RowData);

                // แสดงข้อความและชื่อ
                Name.text = data[LoadRow * 4 + columnName];
                Dialog.text = data[LoadRow * 4 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 4 + columnSprite]);


               

           }
            

    }


    public void DisplaynextText() // Show Next Text
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        //Debug.Log("Current Load Row = " + GameManager2.Instance.RowData);
        //LoadRow = GameManager2.Instance.RowData;

        
        if (GameManager2.Instance.RowData >= data.Length / 4) //Dialog จบแล้ว
        {
            Debug.Log("End of Dialog");
            //SceneManager.LoadScene("TestScene1"); 
            return;
        }
        if(ischoice == false)
        {

                if (GameManager2.Instance.RowData == 2) // test Choice 
            {

                Choicemenu.gameObject.SetActive(true);
                ischoice = true;

            }


             // แสดงชื่อและข้อความ
                Name.text = data[GameManager2.Instance.RowData * 4 + columnName];
                Dialog.text = data[GameManager2.Instance.RowData * 4 + columnDialogue];

            // โหลดและแสดง sprite

                LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 4 + columnSprite]);

                GameManager2.Instance.SavedRow();
                
        }
    }

    private void LoadAndDisplaySprite(string spriteName)
    {
        spriteName = spriteName.Remove(spriteName.Length -1);
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
        ischoice = false;
        DisplaynextText();


    }
    public void Choice2() //เลือก Choice 2
    {
        Debug.Log("Choice 2");
        Choicemenu.gameObject.SetActive(false);
         ischoice = false;
         DisplaynextText();
    }
    public void Choice3() //เลือก Choice 3
    {
        Debug.Log("Choice 3");
        Choicemenu.gameObject.SetActive(false);
         ischoice = false;
         DisplaynextText();
    }
}
