using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string correctItemTag; // Tag to identify the correct item

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        // Snap the dropped item to the drop zone's position
        RectTransform droppedRectTransform = dropped.GetComponent<RectTransform>();
        RectTransform dropZoneRectTransform = GetComponent<RectTransform>();

        // Align the dropped item with the drop zone
        droppedRectTransform.anchoredPosition = dropZoneRectTransform.anchoredPosition;

        // Optionally, you can also disable dragging after snapping to prevent further movement
        //dropped.GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (dropped != null && dropped.CompareTag(correctItemTag))
        {
            Debug.Log("Correct item dropped!");
            dropped.GetComponent<Draggable>().setGavityzero();

        }
        else
        {
            Debug.Log("Wrong item dropped.");
            // Optionally, handle what happens when the wrong item is dropped
        }
    }
}
