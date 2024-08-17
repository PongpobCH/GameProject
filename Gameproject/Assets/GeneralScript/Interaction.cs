using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{

    public bool isInrange;
    public KeyCode interactkey;
    public UnityEvent interaction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInrange)
        {
            if(Input.GetKeyDown(interactkey))
            {
                interaction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInrange = true;
            Debug.Log("Now Player in Range");
        }
    }
    private void OnTriggerExit2D(Collider2D collision) 
    {
       if(collision.gameObject.CompareTag("Player"))
        {
            isInrange = true;
            Debug.Log("Now Player out of Range");
        }  
    }
}
