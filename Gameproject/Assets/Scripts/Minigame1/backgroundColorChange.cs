using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundColorChange : MonoBehaviour
{
    public SpriteRenderer rawImage; // Assign your RawImage in the inspector
    public Color startColor = Color.red; // Color at 0% (e.g., red)
    public Color endColor = new Color(0.5f, 1f, 0.5f); // Color at 100% (e.g., light green)
    [Range(0, 100)]

    float playerPercentage = 0f; // Percentage from 0 to 100

    private void Start()
    {
        // Set the initial color based on the initial percentage
        UpdateColor(playerPercentage);
    }

    private void Update()
    {
        // Continuously update the color based on the player's percentage
        UpdateColor(playerPercentage);
    }

    public void UpdateColor(float percentage)
    {
        // Clamp the percentage between 0 and 100
        percentage = Mathf.Clamp(percentage, 0f, 100f);

        // Normalize the percentage to a value between 0 and 1
        float t = percentage / 100f;

        // Interpolate between the start and end colors based on the percentage
        rawImage.color = Color.Lerp(startColor, endColor, t);
    }

    public void setColorPercentage(float percentage)
    {
        playerPercentage = percentage;
    }
}
