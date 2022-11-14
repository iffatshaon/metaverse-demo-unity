using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if(entered)
        {
            Debug.Log("Entering Scene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = true;
        entered = true;
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = false;
        entered = false;
    }
}
