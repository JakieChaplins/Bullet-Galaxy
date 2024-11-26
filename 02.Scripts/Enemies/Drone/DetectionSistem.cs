using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSistem : MonoBehaviour
{
    [SerializeField] MovimientoDrone MovDrone;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
            MovDrone.detected = true;
       }
    }
   
    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.CompareTag("Player"))
         {
            MovDrone.detected = false;
         }
    }

}
