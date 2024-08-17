using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour
{
    public RawImage rawImage; // Reference to the SpriteRenderer component
    public Color color;
    public int point;

    void Start()
    {
        // Get the RawImage component attached to this GameObject
        rawImage = GetComponent<RawImage>();
        
    }

    void Update()
    {
        // Check if the player has clicked the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the mouse is over this UI element
            if (IsMouseOverUI())
            {
                // Change the color of the RawImage to a random color
                ChangeColor();
            }
        }
    }

    private bool IsMouseOverUI()
    {
        // Convert the mouse position to a position relative to the Canvas
        Vector2 localMousePosition = (Vector2)Input.mousePosition - (Vector2)rawImage.rectTransform.position;

        // Check if the local mouse position is within the bounds of the RawImage
        return rawImage.rectTransform.rect.Contains(localMousePosition);
    }

    void ChangeColor()
    {
        // Change the color of the RawImage to a random color
        rawImage.color = color;
        Minigame2_Controller.Instance.setPlayerProgression(point);
    }
}