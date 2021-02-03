using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bozkurt : MonoBehaviour
{
    public Animator kurt;
 
    void Start()
    {
        kurt.enabled = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            kurt.enabled = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            kurt.enabled = false;
        
        }
        
    }
}
