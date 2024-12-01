using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class miniGame1_Controller : MonoBehaviour
{
    [SerializeField]
    private bool isGameEnd = true;
    textGeneration textGen;
    swipeDetection swipeDect;
    backgroundColorChange bg;
    public LevelLoader levelscript;

    public SpriteRenderer playerSprite;
    public Sprite[] playerSpriteList;

    public GameObject Tutorial_UI;

    public RectTransform imageTransform; // Assign the RectTransform of the Image in the Inspector
    public float popDuration = 1.0f; // Duration of the pop-out effect
    public float holdDuration = 2.0f; // Duration to hold the image before changing the scene
    public string sceneToLoad = "NextScene"; // Name of the scene to load

    private Vector3 originalScale;

    void Start()
    {
        setGameEndStatus(true);

        textGen = this.GetComponent<textGeneration>();
        swipeDect = this.GetComponent<swipeDetection>();
        bg = this.GetComponent<backgroundColorChange>();    
        Tutorial_UI.SetActive(true);

        originalScale = imageTransform.localScale; // Store the original scale
        imageTransform.localScale = Vector3.zero; // Start with the image scale at 0
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
        float elapsedTime = 0f;
        while (elapsedTime < popDuration)
        {
            imageTransform.localScale = Vector3.Lerp(Vector3.zero, originalScale, elapsedTime / popDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        imageTransform.localScale = originalScale; // Ensure it reaches the original scale

        // Hold the image at its original scale for a few seconds
        yield return new WaitForSeconds(holdDuration);

        triggerMinigameEnd();
    }
    void triggerMinigameEnd()
    {
        Debug.Log("ร้อยแล้วววว");
        levelscript.LoadDay1();

        // do something after minigame end here
    }
}
