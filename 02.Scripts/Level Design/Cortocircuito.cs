using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortocircuito : MonoBehaviour
{
    public AudioSource explosionSound;

    public GameObject panelGeometry;
    public GameObject explosion;
    public GameObject lasers;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject, 2f);
            panelGeometry.SetActive(false);
            lasers.SetActive(false);
            explosion.SetActive(true);
            explosionSound.Play();
        }
    }
}
