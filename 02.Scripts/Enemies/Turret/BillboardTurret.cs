using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardTurret : MonoBehaviour
{
    Camera theCam;

    private void Start()
    {
        theCam = Camera.main;
    }

    private void Update()
    {
        transform.LookAt(theCam.transform);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
    }
}
