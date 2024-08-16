using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxSpawner : MonoBehaviour
{
    public GameObject targetPrefab; // Assign your UI prefab in the Inspector
    public RectTransform canvasRectTransform; // Assign the Canvas' RectTransform
    public float spawnInterval = 2f; // Time between spawns

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnTarget();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnTarget()
    {
        // Instantiate the target prefab under the Canvas
        GameObject targetInstance = Instantiate(targetPrefab, canvasRectTransform);

        // Set the target's RectTransform properties
        RectTransform targetRectTransform = targetInstance.GetComponent<RectTransform>();

        // Generate a random position within the canvas
        float randomX = Random.Range(-canvasRectTransform.rect.width / 2, canvasRectTransform.rect.width / 2);
        float randomY = Random.Range(-canvasRectTransform.rect.height / 2, canvasRectTransform.rect.height / 2);

        // Set the position of the UI element
        targetRectTransform.anchoredPosition = new Vector2(randomX, randomY);
    }
}
