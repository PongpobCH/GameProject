using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupitem : MonoBehaviour
{

    public bool ispickup;
    
    
    public void pickup()
    {
        if (!ispickup)
        {
            ispickup = true;
            Debug.Log("Pick up an item");
            
            Destroy(gameObject);
            

        }
    }
    public void DestroySelf(float delay = 5f)
    {
        Destroy(gameObject, delay);
        Debug.Log("Object will be destroyed after delay.");
    }
}
