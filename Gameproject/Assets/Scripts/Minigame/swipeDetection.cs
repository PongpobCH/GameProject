using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class swipeDetection : MonoBehaviour
{
    Vector3 CurrentPosition;
    [SerializeField]
    float increasingRate;
    [SerializeField]
    float percentage = 0;

    void Start()
    {
      CurrentPosition = Input.mousePosition;
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && CurrentPosition!=Input.mousePosition)
        {
            addToPercentage();
        }
        CurrentPosition = Input.mousePosition;
    }

    void addToPercentage()
    {
        percentage += increasingRate;
    }

    /* [SerializeField]
     InputActionAsset swipeInputActions;
     [SerializeField]
     float maxSwipeTime = 0.5f;
     [SerializeField]
     int minSwipeDistance = 100;

     public bool swiping = false;
     public float swipeAngle = 0f;

     Vector2 swipeStartPosition;
     Vector2 swipeEndPosition;

     float swipeStartTime;
     float swipeEndTime;

     void OnEnable()
     {
         swipeInputActions.Enable();
     }
     void OnDisable()
     {
         swipeInputActions.Disable();    
     }

     void Start()
     {
         swipeInputActions.FindAction("Touch").performed += SwipeStart;
         swipeInputActions.FindAction("Touch").canceled += SwipeEnd;
     }

     void SwipeStart(InputAction.CallbackContext context)
     {
         swiping = true;
         swipeStartPosition = swipeInputActions.FindAction("TouchPosition").ReadValue<Vector2>();
         swipeStartTime = Time.time;
     }

     void SwipeEnd(InputAction.CallbackContext context)
     {
         if(swiping)
         {
             swipeEndPosition = swipeInputActions.FindAction("TouchPosition").ReadValue<Vector2>();
             Vector2 swipeDelta = swipeEndPosition - swipeStartPosition;

             if(swipeDelta.sqrMagnitude >= minSwipeDistance)
             {
                 swipeAngle = Mathf.Atan2(swipeDelta.y,swipeDelta.x) * Mathf.Rad2Deg;
                 if(swipeAngle < 0f)
                 {
                     swipeAngle += 360f;
                 }

                 if(swipeAngle > 45f && swipeAngle<=135f) { Debug.Log("UP"); }
                 else if (swipeAngle > 225f && swipeAngle <= 315f) { Debug.Log("UP"); }

             }
         }

         swiping = false;
         swipeEndTime = Time.time;
     }*/
}
