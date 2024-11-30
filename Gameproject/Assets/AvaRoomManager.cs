using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvaRoomManager : MonoBehaviour
{
   
    public GameManager2 gameManager2script;


    void Start()
    {
       GameManager2.Instance.LoadAvaroomtimes++;

        Debug.Log("AvaRoomTimes " + gameManager2script.LoadAvaroomtimes);

    }

    
}
