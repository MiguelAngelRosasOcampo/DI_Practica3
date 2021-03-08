using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Interactable : MonoBehaviour
{
    public bool isTrigger;

    public void Start() 
    {
        isTrigger = false;
    }
    
    public virtual void Update() 
    {
        if(isTrigger)
            Interact();
    }

    public void OnTriggerEnter(Collider other) 
    {
        isTrigger = true;   
    }

    public void OnTriggerExit(Collider other) 
    {
        isTrigger = false;    
    }

    public virtual void Interact()
    {

    }
}
