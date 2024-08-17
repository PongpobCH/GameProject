using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerExitHandler
{
    public string correctItemTag; // Tag to identify the correct item
    private bool isCorrectlyDropped = false;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null && dropped.CompareTag(correctItemTag))
        {
            Debug.Log("Correct item dropped!");

            // Snap the dropped item to the drop zone's position
            RectTransform droppedRectTransform = dropped.GetComponent<RectTransform>();
            RectTransform dropZoneRectTransform = GetComponent<RectTransform>();

            // Align the dropped item with the drop zone
            droppedRectTransform.anchoredPosition = dropZoneRectTransform.anchoredPosition;

            // Optionally, disable further dragging after snapping
            dropped.GetComponent<CanvasGroup>().blocksRaycasts = true;
            dropped.GetComponent<Draggable>().setGavityzero();

            // If it's the first time this item is dropped correctly, increment the count
            if (!isCorrectlyDropped)
            {
                Minigame3_Controller.Instance.IncrementCorrectDrop();
                isCorrectlyDropped = true;
            }
        }
        else
        {
            Debug.Log("Wrong item dropped.");
            // Optionally, handle what happens when the wrong item is dropped
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject draggedItem = eventData.pointerDrag;

        if (draggedItem != null && draggedItem.CompareTag(correctItemTag) && isCorrectlyDropped)
        {
            Debug.Log("Correct item removed!");

            // Decrement the count if the correct item is dragged out of the drop zone
            Minigame3_Controller.Instance.DecrementCorrectDrop();
            isCorrectlyDropped = false;
        }
    }
}
