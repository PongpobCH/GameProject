using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slashDetection : MonoBehaviour
{
    private Vector2 startPos;
    private bool isSwiping;

    void Update()
    {
        DetectSwipe();
    }

    void DetectSwipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the starting position of the swipe
            startPos = Input.mousePosition;
            isSwiping = true;
        }
        else if (Input.GetMouseButtonUp(0) && isSwiping)
        {
            // Get the end position of the swipe
            Vector2 endPos = Input.mousePosition;

            // Find all active UI targets in the scene
            List<GameObject> uiTargets = GetAllUITargets();

            // Check if the swipe intersects with any of the targets
            foreach (GameObject target in uiTargets)
            {
                if (IsSwipeThroughTarget(startPos, endPos, target))
                {
                    Destroy(target);
                }
            }

            isSwiping = false;
        }
    }

    List<GameObject> GetAllUITargets()
    {
        // Find all UI targets in the scene by tag (assumes all targets have the same tag, e.g., "UITarget")
        GameObject[] targets = GameObject.FindGameObjectsWithTag("UITarget");
        return new List<GameObject>(targets);
    }

    bool IsSwipeThroughTarget(Vector2 start, Vector2 end, GameObject target)
    {
        // Convert the UI target's screen coordinates to world coordinates
        RectTransform targetRectTransform = target.GetComponent<RectTransform>();
        Vector3[] worldCorners = new Vector3[4];
        targetRectTransform.GetWorldCorners(worldCorners);

        // Create a bounding box for the target
        Rect targetRect = new Rect(worldCorners[0], worldCorners[2] - worldCorners[0]);

        // Check if either the start or end position is within the target's bounding box
        return targetRect.Contains(start) || targetRect.Contains(end);
    }
}
