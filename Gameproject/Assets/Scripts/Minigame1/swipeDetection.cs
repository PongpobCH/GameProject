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

    miniGame1_Controller gm;

    void Start()
    {
        gm = this.GetComponent<miniGame1_Controller>();
        CurrentPosition = Input.mousePosition;
    }
    void Update()
    {
        if (!gm.getGameEndStatus())
        {
            addToPercentage();
            CurrentPosition = Input.mousePosition;
        }
    }

    void addToPercentage()
    {
        if (Input.GetMouseButton(0) && CurrentPosition != Input.mousePosition)
        {
            percentage += increasingRate;
        }
    }

    public float getPercentage()
    {
        return percentage;
    }

}
