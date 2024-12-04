using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool IsCurrentScene(string sceneName)
    {
        return SceneManager.GetActiveScene().name == sceneName;
    }

    public void checkforchoice(){
        if(GameManager2.Instance.RowData == 63 && IsCurrentScene("Day2"))
        {
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }
        else  if (GameManager2.Instance.RowData == 74 && IsCurrentScene("Day1")) //first choice เกิดอะไรขึ้น
        {
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }
        else if (GameManager2.Instance.RowData == 88 && IsCurrentScene("Day1")) //first choice เกิดอะไรขึ้น
        {
            ChoiceUI02.SetActive(true);
            ContinueButton.SetActive(false);
        }

    }

    public void GOGOPOWERRANGER() { choiceUI01.SetActive(false); ContinueButton.SetActive(true); }
    
    public void D1Q1(int index){ //รู้จักโรควิตกกังวลไหม

        //Debug.Log("AnswerA");
        if(index == 1) {
            changeText("Ava","รู้จักสิ..มันคืออาการที่ความวิตกกังวล ความกลัว ความเครียดมีมากกจนส่งผลกระทบต่อการใช้ชีวิต เช่น กินไม่ได้/กินมากไป นอนไม่หลับ/นอนมากไป ไม่มีสมาธิจดจ่อกับเรื่องต่างๆ ที่เคยจดจ่อได้ ติดต่อกันเป็นเวลา 2 สัปดาห์ขึ้นไปไงละ", "ava_think_hmm");
        }
        else
        {
            changeText("Red",".มันคืออาการที่ความวิตกกังวล ความกลัว ความเครียดมีมากกจนส่งผลกระทบต่อการใช้ชีวิต เช่น กินไม่ได้/กินมากไป นอนไม่หลับ/นอนมากไป ไม่มีสมาธิจดจ่อกับเรื่องต่างๆ ที่เคยจดจ่อได้ ติดต่อกันเป็นเวลา 2 สัปดาห์ขึ้นไปไงละ", "red_idle_smile");
        }
        ContinueButton.SetActive(true);

        choiceUI01.SetActive(false);
    }
    public void D1Q2(int index)
    { //รู้จักโรควิตกกังวลไหม

        if (index == 1)
        {
            changeText("Ava", "สารเคมีในสมองขาดสมดุลงั้นเหรอ...?", "ava_think_hmm");
        }
        else if(index == 2)
        {
            changeText("Ava", "แม่ของฉันกดดันฉันบ่อยๆ หรือว่าบางที..?", "ava_think_hmm");
        }
        else
        {
            changeText("Ava", "กรรมพันธุ์งั้นเหรอ? แม่ของฉันก็หงุดหงิดง่ายเหมือนกัน...", "ava_think_hmm");

        }
        ContinueButton.SetActive(true);

        ChoiceUI02.SetActive(false);
    }

    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage;
    public GameObject CharacterImageRed;

    private void changeText(string name,string textthisline, string spritename)
    {
        Name.text = "Ava";
        Dialog.text = textthisline;

        // โหลดและแสดง sprite

        LoadAndDisplaySprite(spritename);
    }
    private void LoadAndDisplaySprite(string spriteName)
    {
        string folderPath = "Sprites/Characters/";
        string keywordava = "ava"; // Load Only Ava Keyword
        string keywordred = "red"; // Load Only Ava Keyword

        if (spriteName.Contains(keywordava))
        {
            Sprite sprite = Resources.Load<Sprite>((folderPath + spriteName).Trim());
            CharacterImage.gameObject.SetActive(false);

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
        if (spriteName.Contains(keywordred) || spriteName.Contains("extra"))
        {
            Sprite sprite = Resources.Load<Sprite>((folderPath + spriteName).Trim());
            CharacterImageRed.gameObject.SetActive(false);

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
    }


}
