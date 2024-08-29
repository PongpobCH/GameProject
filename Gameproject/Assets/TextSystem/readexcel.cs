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

public class readexcel : MonoBehaviour
{
    
    public TextAsset textAssetdata; 
    public TextMeshProUGUI Dialogue; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public int Loadtimes;
    public int LoadRow;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 2; // คอลัมน์ที่เก็บชื่อ Sprite


    void Start()
    {

       
        Loadtimes = GameManager2.Instance.Loadtimes;

        //Debug.Log ("Loadtimes = " + Loadtimes);




            if (Loadtimes == 0)
            {
                Debug.Log("Load 1 times ");

                GameManager2.Instance.Loadtimes++;

                LoadRow = GameManager2.Instance.RowData;

                Debug.Log("LoadSavedRow = " + GameManager2.Instance.RowData);

                

                string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

                // แสดงข้อความและชื่อ
                Name.text = data[LoadRow * 3 + columnName];
                Dialogue.text = data[LoadRow * 3 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 3 + columnSprite]);

                
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
                Name.text = data[LoadRow * 3 + columnName];
                Dialogue.text = data[LoadRow * 3 + columnDialogue];

                // โหลดและแสดง sprite
                LoadAndDisplaySprite(data[LoadRow * 3 + columnSprite]);

                
                //GameManager2.Instance.SavedRow();

               

           }
            

    }


    public void DisplaynextText()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        //Debug.Log("Current Load Row = " + GameManager2.Instance.RowData);
        //LoadRow = GameManager2.Instance.RowData;

        if (GameManager2.Instance.RowData >= data.Length / 3) //End of Dialog
        {

            Debug.Log("Finished");
            SceneManager.LoadScene("TestScene1");

            return;

        }

        // แสดงชื่อและข้อความ
        Name.text = data[GameManager2.Instance.RowData * 3 + columnName];
        Dialogue.text = data[GameManager2.Instance.RowData * 3 + columnDialogue];

        // โหลดและแสดง sprite
        LoadAndDisplaySprite(data[GameManager2.Instance.RowData * 3 + columnSprite]);

        GameManager2.Instance.SavedRow();
        


    }

    private void LoadAndDisplaySprite(string spriteName)
    {
        spriteName = spriteName.Remove(spriteName.Length - 1);
        string folderPath = "Sprites/Characters/";

        // โหลด Sprite จากโฟลเดอร์ที่ระบุ
        Sprite sprite = Resources.Load<Sprite>(folderPath+spriteName);
        //Debug.Log(spriteName.Length);

        // ถ้าพบ sprite ที่มีชื่อตรงกัน จะแสดงผลใน Image ที่กำหนด
        if (sprite != null)
        {
            CharacterImage.GetComponent<SpriteRenderer>().sprite = sprite;
        }
        else
        {
            //Debug.LogWarning("Sprite not found: " + folderPath + spriteName);
        }

       
    }
}
