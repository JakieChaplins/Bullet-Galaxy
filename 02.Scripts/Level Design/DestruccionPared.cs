using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionPared : MonoBehaviour
{
    public AudioSource explosionSound;

    public GameObject wallGeometry;
    public GameObject explosion;

    public void WallDestruction()
    {
            Destroy(gameObject, 2f);
            wallGeometry.SetActive(false);
            explosion.SetActive(true);
            explosionSound.Play();
    }
}
