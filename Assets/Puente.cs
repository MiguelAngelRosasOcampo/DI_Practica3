using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Puente : Interactable
{
    // Update is called once per frame
    public override void Update()
    {
        base.Update();   
    }

    public override void Interact()
    {
        if(isTrigger && Input.GetKey(KeyCode.P))   
        {
            transform.Translate(new Vector3(0, -5, 0));
            Debug.Log("Has tomado el puente");
        }    }
}
