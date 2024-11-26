using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruction : MonoBehaviour
{
    public AudioSource explosionSound;

    public GameObject geometry;
    public GameObject explosion;
    public GameObject drone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(drone, 0.5f);
            geometry.SetActive(false);
            explosion.SetActive(true);
            explosionSound.Play();
        }
    }
}
