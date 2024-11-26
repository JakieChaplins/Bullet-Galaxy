using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDrone : MonoBehaviour
{
    public float speed;

    public bool detected = false;

    void Update()
    {
        if (detected == true)
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
