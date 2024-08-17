using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame3_Controller : MonoBehaviour
{
    public static Minigame3_Controller Instance { get; private set; }
    private int correctDropsCount = 0;

    public GameObject UImenu;
    public void startGame()
    {
        UImenu.SetActive(false);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this instance persistent across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    public void IncrementCorrectDrop()
    {
        correctDropsCount++;
        Debug.Log("Correct Drops: " + correctDropsCount);
        CheckWinCondition();
    }

    public void DecrementCorrectDrop()
    {
        if (correctDropsCount > 0)
        {
            correctDropsCount--;
            Debug.Log("Correct Drops: " + correctDropsCount);
        }
    }

    private void CheckWinCondition()
    {
        if (correctDropsCount >= 6)
        {
            Debug.Log("You win!");
            // Trigger win state here (e.g., load a new scene, show a win UI, etc.)
            OnWin();
        }
    }

    private void OnWin()
    {
        // Implement the win logic here
        // For example, you can display a win message, stop the game, or load a new scene.
        Debug.Log("Congratulations! You've won the game!");

        // Example: Show a win UI (Assume you have a UI panel for the win screen)
        // winScreen.SetActive(true);

        // Example: Load a win scene
        // UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");

        // Optionally, you can stop the game or freeze player input
        // Time.timeScale = 0; // This stops the game by freezing time
    }

    public int GetCorrectDropsCount()
    {
        return correctDropsCount;
    }
}
