using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionTurret : MonoBehaviour
{
    [SerializeField] BillboardTurret billy;
    [SerializeField] TurretShot shot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Me detectó");

            shot.startShooting = true;
           // billy.enabled = true;
            shot.shotToPlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            shot.startShooting = false;
            //billy.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            shot.startShooting = true;
            billy.enabled = true;
            shot.shotToPlayer();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            shot.startShooting = false;
            billy.enabled = false;
        }
    }
}
