using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupitem : MonoBehaviour
{

    public bool ispickup;

    public EntityChecker entityCheckerscript;
    public ParkSceneManager parkSceneManagerscript;
    
    
    public void pickup()
    {

        if (!ispickup)
        {
            ispickup = true;
            entityCheckerscript.collectreddiary(); 
            Debug.Log("Pick up an item");

            parkSceneManagerscript.cutin1();
            
            Destroy(gameObject);
            

        }
    }
    public void DestroySelf(float delay = 5f)
    {
        Destroy(gameObject, delay);
        Debug.Log("Object will be destroyed after delay.");
    }
}
