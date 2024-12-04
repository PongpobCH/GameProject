using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using JetBrains.Annotations;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class choicemanagerday3 : MonoBehaviour
{
   
    public LevelLoader loadlevelscript;
    public GameObject choiceUI01;
    public GameObject choiceUI02;
    public GameObject choiceUI3A;
    public GameObject choiceUI3B;
    public GameObject choiceUI3C;

    public GameObject choicereseting;

    /*public GameObject AnswerSet1;
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
    public GameObject AnswerCF1;
    public GameObject AnswerFB1;
    public GameObject AnswerFC;*/

    public GameObject DialogUI;
    public GameObject ContinueButton;
    //public GameObject ChoiceUI02; 

    //public GameObject AnswerA2;
    public char route = 'A';
    

   
    void Start()
    {
        choiceUI01.SetActive(false);
        choiceUI02.SetActive(false);
        choiceUI3A.SetActive(false);
        choiceUI3B.SetActive(false);
        choiceUI3C.SetActive(false);
        choicereseting.SetActive(false);

    }

    public void checkforchoice()
    {

        if (GameManager2.Instance.RowData == 19) //first choice เกิดอะไรขึ้น
        {
            choiceUI01.SetActive(true);
            ContinueButton.SetActive(false);
        }

        if (GameManager2.Instance.RowData == 22) //second รู้สึกยังไง
        {
            choiceUI02.SetActive(true);
            ContinueButton.SetActive(false);
        }

        if (GameManager2.Instance.RowData == 25) //third เพราะอะไรถึงคิด
        {
            ContinueButton.SetActive(false);
            switch (route)
            {
                case 'A': choiceUI3A.SetActive(true); break;
                case 'B': choiceUI3B.SetActive(true); break;
                default: choiceUI3C.SetActive(true); break;
            }
        }
        if (GameManager2.Instance.RowData == 30) //fourth ค้านสิ่งที่คิด
        {
            switch (route)
            {
                case 'A': changeText("ฉันเคยทำงานที่ใหญ่กว่านี้ในเวลาเท่าๆกันเสร็จมาแล้ว ถึงจะเคยส่งงานไม่ทัน แต่ตอนนี้มันต่างกันที่ฉันมีคนให้ถามถ้าสงสัย", "ava_idle_frown"); break;
                case 'B': changeText("ถ้าอยู่ๆก็มีคนตะคอกขึ้นมา ฉันก็คงจะหันไปมองเหมือนกัน และฉันก็จ่ายเงินครบจริงๆ ฉันอธิบายให้เขาฟังได้ถ้ากระเป๋าคนนั้นยังยืนกรานอยู่", "ava_idle_frown"); break;
                default: changeText("แม่เชื่อมั่นในความสามารถของฉัน แล้วก็..นอกจากแม่แล้ว.ฌพื่อนๆกับอาจารย์ก็ชื่นชมฉันในเรื่องนี้ด้วย", "ava_idle_frown"); break;
            }
        }

        if (GameManager2.Instance.RowData == 35) //fourth ค้านสิ่งที่คิด
        {
            switch (route)
            {
                case 'A': changeText("ฉันไม่จำเป็นต้องทำงานนี้ให้เพอร์เฟ็ค แต่ถึงอย่างนั้น ฉันก็ทำงานทันจนมีงานส่ง", "ava_idle_frown"); break;
                case 'B': changeText("ฉันจ่ายเงินไปครบแล้วจริงๆ และวันนั้นอากาศก็ร้อนแถมคนเยอะ กระเป๋ารถเมล์คงจะหงุดหงิด ถ้ามีปัญหาอะไรตามมา ฉันว่าฉันอธิบายได้นะ", "ava_idle_frown"); break;
                default: changeText("นี่ก็ไม่ใช่เวทีแรก ฉันเคยผ่านอะไรแบบนี้มาก่อน แค่ตั้งใจให้เหมือนกับทุกครั้ง มันจะต้องผ่านไปได้ดีแน่ๆ", "ava_idle_frown"); break;
            }
        }
        if (GameManager2.Instance.RowData == 44) //fourth ค้านสิ่งที่คิด
        {
            choicereseting.SetActive(true);
            ContinueButton.SetActive(false);
        }
    }

    public void firstChoiceSaveRoute(string a)
    {
        choiceUI01.SetActive(false);

        route = a[0];
        switch (route)
        {
            case 'A': changeText("ฉันทำงานไม่ทันส่งเมื่อวาน", "ava_idle_frown"); break;
            case 'B': changeText("ฉันโดนกระเป๋ารถเมล์ดุ", "ava_idle_frown"); break;
            default: changeText("ฉันโดนแม่จี้ให้ซ้อมไวโอลิน", "ava_idle_frown"); break;
        }
        ContinueButton.SetActive(true);
    }
    public void secondChoice(int index)
    {
        choiceUI02.SetActive(false);

        if (index == 1) {
            switch (route)
            {
                case 'A': changeText("ฉัน..เครียดมากเลยล่ะ..งานจะต้องส่งแล้วแต่ฉันยังไม่ได้เริ่มเลย..มันจะไปเสร็จทันได้ยังไง", "ava_idle_frown"); break;
                case 'B': changeText("ฉัน..เครียดมากเลยที่ต้องมาเจอเรื่องแบบนี้แต่เช้า..เขาคนนั้นก็ดูจะไม่พอใจฉันด้วย", "ava_idle_frown"); break;
                default: changeText("ฉันก็แค่อยากจะพักบ้าง ทำไมแม่ต้องกดดันให้ซ้อมอยู่แบบนี้ด้วย", "ava_idle_frown"); break;
            }
        }
        else if (index == 2)
        {
            switch (route)
            {
                case 'A': changeText("ฉันเศร้ามากเลยล่ะถ้าฉัน..รู้ว่ามีงานนี้ตั้งแต่วันก่อน..ก็คงจะไม่ต้องมารีบทำขนาดนั้น", "ava_idle_frown"); break;
                case 'B': changeText("มันเศร้านะที่เขาเข้าใจฉันแบบนั้น..ขอโทษสักคำยังไม่มีเลย", "ava_idle_frown"); break;
                default: changeText("มันเศร้านะที่ต้องทำตามที่แม่สั่งอยู่ตลอดแบบนี้น่ะ..", "ava_idle_frown"); break;
            }
        }
        else
        {
            switch (route)
            {
                case 'A': changeText("ฉัน..กังวลว่าจะไม่มีงานส่ง ถ้าทำไม่ทันจะต้องมีเรื่องกับอาจารย์แน่ๆ", "ava_idle_frown"); break;
                case 'B': changeText("ฉัน.. กังวลว่าคนอื่นในรถจะคิดว่าฉันโกง..ฉันไม่อยากให้คนอื่นมองฉันไม่ดี..", "ava_idle_frown"); break;
                default: changeText("ฉัน..ไม่อยากให้แม่ผิดหวัง.. ฉันกังวลมากๆว่าฉันยังพยายามไม่พอ..", "ava_idle_frown"); break;
            }
        }
        ContinueButton.SetActive(true);
    }
    public void thirdChoice(int index)
    {
        choiceUI3A.SetActive(false);
        choiceUI3B.SetActive(false);
        choiceUI3C.SetActive(false);

        if (index == 1)
        {
            switch (route)
            {
                case 'A': changeText("เพื่อนของฉันเคยทำงานไม่ทันในวิชานี้..แล้วเขาก็โดนตำหนิหนักมากเลย", "ava_idle_frown"); break;
                case 'B': changeText("สายตาจากทุกคนบนรถที่มองมาที่ฉัน เหมือนกับว่าฉันไม่อาชญากรยังไงอย่างนั้นเลย", "ava_idle_frown"); break;
                default: changeText("แม่มักจะยุ่งอยู่เสมอเลย.. เรื่องนี้เป็นเรื่องเดียวที่เธอสนับสนุนฉัน เธอคาดหวังกับฉันในงานแสดงครั้งนี้เอามากๆเลยล่ะ", "ava_idle_frown"); break;
            }
        }
        else
        {
            switch (route)
            {
                case 'A': changeText("ฉัน..เคยโดนอาจารย์คนอื่นตำหนิหลังจากส่งงานไม่ทันมาก่อน", "ava_idle_frown"); break;
                case 'B': changeText("น้ำเสียงของกระเป๋ารถเมล์คนนั้นน่ะ..เขาตะคอก..แล้วดูเหมือนจะหงุดหงิดอยู่ด้วย", "ava_idle_frown"); break;
                default: changeText("แม่เคยทำพลาดในงานแสดงใหญ่ๆแบบนี้มาก่อน ฉันมั่นใจว่าเธอไม่อยากให้ฉันต้องเจอเหมือนเธอ", "ava_idle_frown"); break;
            }
        }
        ContinueButton.SetActive(true);
    }

    public void resetChoice(int index)
    {
        ContinueButton.SetActive(true);
        choicereseting.SetActive(false);
        if (index == 2){ GameManager2.Instance.RowData = 15; GameManager2.Instance.SavedRow(); }
        changeText("ได้เลย","");
    }


    public TextMeshProUGUI Dialog; //Show dialog Line
    public TextMeshProUGUI Name; // Show name from dialog 
    public GameObject CharacterImage;
    private void changeText(string textthisline,string spritename)
    {
        Name.text ="Ava";
        Dialog.text = textthisline;

        // โหลดและแสดง sprite

        LoadAndDisplaySprite(spritename);
    }
    private void LoadAndDisplaySprite(string spriteName)
    {
        string folderPath = "Sprites/Characters/";
        string keywordava = "ava"; // Load Only Ava Keyword

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
    }
}
