using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class givevalue : MonoBehaviour
{
 

    void Start()
    {
       
        int loadintfromdata = staticdata.valueTokeep;
        Debug.Log("Load int = " + loadintfromdata + "from data"); 

    }

   
}
