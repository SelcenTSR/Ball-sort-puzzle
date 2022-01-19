using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAir : MonoBehaviour
{
   


    #region SINGLETON PATTERN
    private static InAir _instance;
    public static InAir Instance { get { return _instance; } }
    private void Awake()
    {

        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    #endregion

    public bool inAir = false;





    public void OnTriggerEnter(Collider nesne)
    {
        if (nesne.transform.tag == "Blue" || nesne.transform.tag == "Red"||nesne.transform.tag=="Purple" || nesne.transform.tag == "Yellow" || nesne.transform.tag == "Green")
        {
            inAir= true;
          

        }
    }
    private void OnTriggerExit(Collider nesne)
    {
        if (nesne.transform.tag == "Blue" || nesne.transform.tag == "Red" || nesne.transform.tag == "Purple" || nesne.transform.tag == "Yellow" || nesne.transform.tag == "Green")
        {
            inAir = false;
          
        }
    }
}