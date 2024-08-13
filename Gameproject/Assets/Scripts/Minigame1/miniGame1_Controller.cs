using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniGame1_Controller : MonoBehaviour
{
    [SerializeField]
    private bool isGameEnd = true;
    textGeneration textGen;
    swipeDetection swipeDect;
    public GameObject Tutorial_UI;
    
    void Start()
    {
        setGameEndStatus(true);

        textGen = this.GetComponent<textGeneration>();
        swipeDect = this.GetComponent<swipeDetection>();
        Tutorial_UI.SetActive(true);
    }
    void Update()
    {
       if(!isGameEnd) { checkPercentage(swipeDect.getPercentage());  }
       
    }

    void checkPercentage(float percentage)
    {
        if (percentage >= 100) { Debug.Log("ร้อยแล้วววว"); setGameEndStatus(true); }
        else if (percentage >= 80) { textGen.setSpawmInterval(2.5f); }
        else if (percentage >= 60) { textGen.setSpawmInterval(2f); }
        else if (percentage >= 40) { textGen.setSpawmInterval(1.5f); }
        else if (percentage >= 20) { textGen.setSpawmInterval(1f); }
        else { textGen.setSpawmInterval(0.5f); }
    }

    public bool getGameEndStatus()
    {
        return isGameEnd;
    }

    public void setGameEndStatus(bool status)
    {
        isGameEnd = status;
    }

    public void startMinigame()
    {
        Tutorial_UI.SetActive(false);
        setGameEndStatus(false);
    }
}
