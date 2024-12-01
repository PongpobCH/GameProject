using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupitem2 : MonoBehaviour
{

    public bool ispickup;

    public EntityChecker entityCheckerscript;
    public ParkSceneManager2 parkSceneManagerscript;

    public LevelLoader levelLoaderscript;
    
    
    public void pickup()
    {

        if (!ispickup)
        {
            ispickup = true;
            entityCheckerscript.collectreddiary(); 
            Debug.Log("Pick up an item");
            
            levelLoaderscript.loadday4();
            Destroy(gameObject);
            

        }
    }
    public void DestroySelf(float delay = 5f)
    {
        Destroy(gameObject, delay);
        Debug.Log("Object will be destroyed after delay.");
    }
}
