using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemetarial1 : MonoBehaviour
{
    
  
    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.transform.tag == "Blue" || nesne.transform.tag == "Red" || nesne.transform.tag == "Purple" || nesne.transform.tag == "Yellow"
            || nesne.transform.tag == "Green")
        {
           InAir.Instance.inAir  = true;
            Debug.Log("havada"+nesne.name);

        }
    }
    private void OnTriggerExit(Collider nesne)
    {
        if (nesne.transform.tag == "Blue" || nesne.transform.tag == "Red" || nesne.transform.tag == "Purple" || nesne.transform.tag == "Yellow" || nesne.transform.tag == "Green")
        {
            InAir.Instance.inAir = false;
            Debug.Log("yerde" + nesne.name);
        }
    }
}
