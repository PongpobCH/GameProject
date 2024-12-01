using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AvaRoomManager : MonoBehaviour
{
   
    public GameManager2 gameManager2script;

    public GameObject violin;
    public GameObject diary;
    public GameObject diaryinteraction;
    public blackscreen cutscenemanager;


    



    void Start()
    {

       GameManager2.Instance.LoadAvaroomtimes++;

        Debug.Log("AvaRoomTimes " + GameManager2.Instance.LoadAvaroomtimes);

        if(GameManager2.Instance.LoadAvaroomtimes == 1)
        {
            violin.gameObject.SetActive(false);
        }

        if(GameManager2.Instance.LoadAvaroomtimes == 2){

            Debug.Log("Enter Ava room 2 times");
            
            violin.SetActive(true);
            diaryinteraction.SetActive(false);
            diary.SetActive(false);


        }

    }

    





    

    
}
