using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // หรือใช้ TMPro หากคุณใช้ TextMeshProUGUI

public class boxSpawner : MonoBehaviour
{
    public GameObject prefab1; // Assign your first UI prefab
    public GameObject prefab2; // Assign your second UI prefab
    public RectTransform canvasRectTransform; // Assign the Canvas' RectTransform

    public float spawnInterval = 1f; // Time between spawns
    public float fallSpeed = 100f; // Speed at which the prefabs fall
    public float lifetime = 5f; // Time after which the prefab will be destroyed

    public List<string> prefab1TextList; // List of texts for the first prefab
    public List<string> prefab2TextList; // List of texts for the second prefab

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (!Minigame2_Controller.Instance.getGameEndStatus()) {
                SpawnPrefab();
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private int consecutivePrefab2Count = 0; // Tracks consecutive prefab2 spawns

    private void SpawnPrefab()
    {
        GameObject prefabToSpawn;

        // Check if prefab2 has been spawned more than twice in a row
        if (consecutivePrefab2Count >= 2)
        {
            prefabToSpawn = prefab1; // Force spawn prefab1
            consecutivePrefab2Count = 0; // Reset the counter
        }
        else
        {
            // Randomly select between prefab1 and prefab2
            prefabToSpawn = (Random.value < 0.5f) ? prefab1 : prefab2;

            // Update the consecutive prefab2 counter
            if (prefabToSpawn == prefab2)
            {
                consecutivePrefab2Count++;
            }
            else
            {
                consecutivePrefab2Count = 0; // Reset the counter if prefab1 is spawned
            }
        }

        // Determine which text list to use based on the selected prefab
        List<string> selectedTextList = (prefabToSpawn == prefab1) ? prefab1TextList : prefab2TextList;

        // Calculate a random X position within the canvas
        float randomX = Random.Range((-canvasRectTransform.rect.width / 3)-10, (canvasRectTransform.rect.width / 3)+10);
        Vector2 spawnPosition = new Vector2(randomX, canvasRectTransform.rect.height / 2);

        // Instantiate the selected prefab under the Canvas
        GameObject instance = Instantiate(prefabToSpawn, canvasRectTransform);

        // Set the RectTransform position of the instantiated prefab
        RectTransform instanceRectTransform = instance.GetComponent<RectTransform>();
        instanceRectTransform.anchoredPosition = spawnPosition;

        // Get the TextMeshPro component from the instance and assign a random text
        TextMeshProUGUI textComponent = instance.GetComponentInChildren<TextMeshProUGUI>();
        textComponent.text = selectedTextList[Random.Range(0, selectedTextList.Count)];

        // Start the falling and destruction coroutine
        StartCoroutine(FallAndDestroy(instanceRectTransform));
    }


    private IEnumerator FallAndDestroy(RectTransform instanceRectTransform)
    {
        // Calculate the fall duration based on lifetime and fall speed
        float elapsed = 0f;

        while (elapsed < lifetime)
        {
            elapsed += Time.deltaTime;
            instanceRectTransform.anchoredPosition += Vector2.down * fallSpeed * Time.deltaTime;
            yield return null;
        }

        // Destroy the object after the fixed lifetime
        Destroy(instanceRectTransform.gameObject);
    }
}
