using System.Collections;
using System.Collections.Generic;
using DIALOGUE;
using UnityEngine;

public class TestParsing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string line = "Speaker \"Dialogue Goes In here!\"Command(arguemnts here)"; 

        DialogueParser.Parse(line);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
