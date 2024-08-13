using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textGeneration : MonoBehaviour
{
    public GameObject uiPrefab; // Assign your UI prefab in the inspector
    public RectTransform canvasRectTransform; // Assign the Canvas' RectTransform
    [SerializeField]
    private float spawnInterval = 2f; // Time between spawns
    public float growDuration = 2f; // Time it takes for the UI element to reach full size
    public float fadeDuration = 1f; // Time it takes for the UI element to fade away
    public Vector2 scaleRange = new Vector2(0.5f, 2f); // Min and Max scale

    miniGame1_Controller gm;

    private void Start()
    {
        gm = this.GetComponent<miniGame1_Controller>();
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (!gm.getGameEndStatus()) { SpawnPrefab(); }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnPrefab()
    {
        // Generate a random position within the canvas
        Vector2 randomPosition = new Vector2(
            Random.Range(-canvasRectTransform.rect.width/2, canvasRectTransform.rect.width/2),
            Random.Range(-canvasRectTransform.rect.height/2, canvasRectTransform.rect.height/2)
        );

        // Instantiate the prefab
        GameObject instance = Instantiate(uiPrefab, canvasRectTransform);
        RectTransform instanceRectTransform = instance.GetComponent<RectTransform>();
        instanceRectTransform.anchoredPosition = randomPosition;
        instanceRectTransform.localScale = Vector3.zero; // Start with zero scale

        // Start the growth and fading routine
        StartCoroutine(GrowAndFade(instance));
    }

    private IEnumerator GrowAndFade(GameObject instance)
    {
        float elapsedTime = 0f;
        float randomScale = Random.Range(scaleRange.x, scaleRange.y);

        // Grow the UI element
        while (elapsedTime < growDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / growDuration;
            instance.GetComponent<RectTransform>().localScale = Vector3.Lerp(Vector3.zero, Vector3.one * randomScale, t);
            yield return null;
        }

        // Reset elapsed time for fading
        elapsedTime = 0f;

        // Get the CanvasGroup component (for fading)
        CanvasGroup canvasGroup = instance.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = instance.AddComponent<CanvasGroup>();
        }

        // Fade the UI element
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / fadeDuration;
            canvasGroup.alpha = 1f - t;
            yield return null;
        }

        // Destroy the UI element after fading
        Destroy(instance);
    }

    public void setSpawmInterval(float timer)
    {
       spawnInterval = timer;
    }
}
