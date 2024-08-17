using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame2_Controller : MonoBehaviour
{
    // Singleton instance
    public static Minigame2_Controller Instance { get; private set; }

    public string correctAnswer = "correctAnswer";
    public string wrongAnswer = "wrongAnswer";

    private int playerProgession = 0;

    private bool isGameEnd = true;
    public GameObject UIstartmenu;

    private backgroundColorChange bg;

    public SpriteRenderer playerSprite;
    public Sprite[] playerSpriteList;

    private void Awake()
    {
        // Singleton pattern implementation
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Prevent this object from being destroyed when loading a new scene
        }
        else
        {
            Destroy(gameObject); // Destroy any duplicate instances
        }
    }

    private void Start()
    {
        bg = GetComponent<backgroundColorChange>();
    }

    private void Update()
    {
        bg.setColorPercentage(playerProgession);
        if (playerProgession >= 100) { isGameEnd = true; StartCoroutine(TriggerMinigameEndTimer()); }
    }

    public void startgame()
    {
        isGameEnd = false;
        UIstartmenu.SetActive(false);
    }

    public bool getGameEndStatus()
    {
        return isGameEnd;
    }
    public void setPlayerProgression(int point)
    {
        playerProgession += point;
        if (playerProgession < 0) { playerProgession = 0; }
        setPlayerSprite();
    }
    void setPlayerSprite()
    {
        if (playerProgession >= 90) { playerSprite.sprite = playerSpriteList[2]; }
        else if (playerProgession >= 50) { playerSprite.sprite = playerSpriteList[1]; }
        else { playerSprite.sprite = playerSpriteList[0]; }
    }

    IEnumerator TriggerMinigameEndTimer()
    {
        yield return new WaitForSeconds(3f);
        triggerMinigameEnd();
    }
    void triggerMinigameEnd()
    {
        Debug.Log("ร้อยแล้วววว");
        // do something after minigame end here
    }
}
