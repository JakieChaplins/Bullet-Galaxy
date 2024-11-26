using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitted : MonoBehaviour
{
    public AudioSource explosionSound;

    public GameObject enemyGeometry;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject, 2f);
            enemyGeometry.SetActive(false);
            explosion.SetActive(true);
            explosionSound.Play();
        }
    }
}
