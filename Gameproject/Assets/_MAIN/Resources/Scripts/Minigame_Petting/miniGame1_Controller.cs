using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class miniGame1_Controller : MonoBehaviour
{
    [SerializeField]
    private bool isGameEnd = true;
    textGeneration textGen;
    swipeDetection swipeDect;
    backgroundColorChange bg;
    public LevelLoader script;

    public SpriteRenderer playerSprite;
    public Sprite[] playerSpriteList;

    public GameObject Tutorial_UI;
    
    void Start()
    {
        setGameEndStatus(true);

        textGen = this.GetComponent<textGeneration>();
        swipeDect = this.GetComponent<swipeDetection>();
        bg = this.GetComponent<backgroundColorChange>();    
        Tutorial_UI.SetActive(true);
    }
    void Update()
    {
       if(!isGameEnd) { checkPercentage(swipeDect.getPercentage());  }
       
    }

    void checkPercentage(float percentage)
    {
        setPlayerSprite(percentage);
        bg.setColorPercentage(percentage);
        if (percentage >= 100) {  setGameEndStatus(true); StartCoroutine(TriggerMinigameEndTimer()); }
        else if (percentage >= 80) { textGen.setSpawmInterval(2.5f); }
        else if (percentage >= 60) { textGen.setSpawmInterval(2f); }
        else if (percentage >= 40) { textGen.setSpawmInterval(1.5f); }
        else if (percentage >= 20) { textGen.setSpawmInterval(1f); }
        else { textGen.setSpawmInterval(0.5f); }
    }

    void setPlayerSprite(float percentage)
    {
        if (percentage >= 90) { playerSprite.sprite = playerSpriteList[2]; }
        else if (percentage >= 50) { playerSprite.sprite = playerSpriteList[1]; }
        else { playerSprite.sprite = playerSpriteList[0]; }
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

    IEnumerator TriggerMinigameEndTimer()
    {
        yield return new WaitForSeconds(3f); 
        triggerMinigameEnd();
    }
    void triggerMinigameEnd()
    {
        Debug.Log("ร้อยแล้วววว");
        script.LoadScene();

        // do something after minigame end here
    }
}
