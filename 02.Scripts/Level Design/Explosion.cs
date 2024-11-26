using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSound;

    [SerializeField] DestruccionPared destrPared;
    [SerializeField] Explosion Expl;
    [SerializeField] Explosion Expl2;
    [SerializeField] Explosion Expl3;

    public GameObject barrelGeometry;
    public GameObject explosion;
    public GameObject explosionCollider;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject, 2f);
            barrelGeometry.SetActive(false);
            explosion.SetActive(true);
            explosionCollider.SetActive(true);
            explosionSound.Play();
            destrPared.WallDestruction();
            Expl.ReaccionCadena();
            Expl2.ReaccionCadena();
            Expl3.ReaccionCadena();

        }
    }
    void ReaccionCadena()
        {
            Destroy(gameObject, 2f);
            barrelGeometry.SetActive(false);
            explosion.SetActive(true);
            explosionCollider.SetActive(true);
            explosionSound.Play();
    }
}
