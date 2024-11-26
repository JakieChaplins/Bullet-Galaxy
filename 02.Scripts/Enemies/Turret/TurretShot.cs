using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShot : MonoBehaviour
{
    public Transform shotInItPoint;
    public GameObject enemyBullet;
    public GameObject Player;

    public float shotForce;

    Transform position_Player;
    public bool startShooting;

    public AudioSource shot;

    private void Start()
    {
        position_Player = Player.transform;
    }

    public void shotToPlayer()
    {
        if (startShooting)
        {
            Vector3 directionPlayer = position_Player.position - transform.position;

            GameObject bullet = Instantiate(enemyBullet, shotInItPoint.position, shotInItPoint.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(directionPlayer * shotForce);
            shot.Play();
            Invoke("shotToPlayer", .3f);

        }
    }
}

