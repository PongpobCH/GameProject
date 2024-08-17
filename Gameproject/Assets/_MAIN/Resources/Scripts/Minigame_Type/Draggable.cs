using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f; // Make the object semi-transparent during drag
        canvasGroup.blocksRaycasts = false; // Allow raycasts to pass through this object
        this.GetComponent<Rigidbody2D>().simulated = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / GetComponentInParent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f; // Restore full opacity
        canvasGroup.blocksRaycasts = true; // Enable raycasts again
    }

    public void setGavityzero()
    {
        this.GetComponent<Rigidbody2D>().simulated = false;
    }

    private void Update()
    {
        Debug.Log(this.GetComponent<Rigidbody2D>().gravityScale);
    }
}
