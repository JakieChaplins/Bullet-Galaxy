using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitted : MonoBehaviour
{
    public GameObject geometry;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject, 0.5f);
            geometry.SetActive(false);
            explosion.SetActive(true);
    }
}
