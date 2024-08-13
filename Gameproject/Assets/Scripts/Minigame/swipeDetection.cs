using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class swipeDetection : MonoBehaviour
{
    textGeneration textGen;
    Vector3 CurrentPosition;
    [SerializeField]
    float increasingRate;
    [SerializeField]
    float percentage = 0;

    void Start()
    {
        CurrentPosition = Input.mousePosition;
        textGen = this.GetComponent<textGeneration>();
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

        if(percentage < 0) percentage = 0;
    }

    void toggleMinigameEnding()
    {

    }

}
