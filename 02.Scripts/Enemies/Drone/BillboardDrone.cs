using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardDrone : MonoBehaviour
{
    Camera theCam;

    private void Start()
    {
        theCam = Camera.main;
    }

    private void Update()
    {
        transform.LookAt(theCam.transform);
    }
}
