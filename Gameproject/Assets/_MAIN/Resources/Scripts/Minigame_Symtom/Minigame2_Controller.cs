using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public RectTransform imageTransform; // Assign the RectTransform of the Image in the Inspector
    public float popDuration = 1.0f; // Duration of the pop-out effect
    public float holdDuration = 2.0f; // Duration to hold the image before changing the scene
    public string sceneToLoad = "NextScene"; // Name of the scene to load

    private Vector3 originalScale;

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
        originalScale = imageTransform.localScale; 
        imageTransform.localScale = Vector3.zero;
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
        // Animate the image growing from scale 0 to its original scale
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

        // Change the scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
