using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEditor.Search;

public class readexcel : MonoBehaviour
{
    
    public TextAsset textAssetdata; 
    public TextMeshProUGUI Dialogue; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage; // ใช้สำหรับแสดงผล Sprite
    public int testvalue;
    public int row = 0; // ตำแหน่งของแถวปัจจุบัน
    private int columnName = 0; // คอลัมน์ที่เก็บชื่อ
    private int columnDialogue = 1; // คอลัมน์ที่เก็บข้อความ
    private int columnSprite = 2; // คอลัมน์ที่เก็บชื่อ Sprite


    void Start()
    {
            
            GameManager2.Instance.IncrementValue();
            testvalue = GameManager2.Instance.RowData;

            Debug.Log("testvalue = " + GameManager2.Instance.RowData);

            string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

            // แสดงข้อความและชื่อ
            Name.text = data[row * 3 + columnName];
            Dialogue.text = data[row * 3 + columnDialogue];

            // โหลดและแสดง sprite
            LoadAndDisplaySprite(data[row * 3 + columnSprite]);


            row++;
            Debug.Log("row = " + row);

    }


    public void DisplaynextText()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        if (row >= data.Length / 3)
        {

            
            //Debug.Log("Finished");

            

            return;

        }

        // แสดงชื่อและข้อความ
        Name.text = data[row * 3 + columnName];
        Dialogue.text = data[row * 3 + columnDialogue];

        // โหลดและแสดง sprite
        LoadAndDisplaySprite(data[row * 3 + columnSprite]);

        row++;
        Debug.Log("row = " + row);

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
            Debug.LogWarning("Sprite not found: " + folderPath + spriteName);
        }
    }
}
