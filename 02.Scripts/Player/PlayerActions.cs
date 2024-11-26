using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform respawn;

    public bool objetivo;
    public bool win;

    public Animator paredes;

    public GameObject naves;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.ammo += other.gameObject.GetComponent<AmmoBox>().ammo;
            GameManager.Instance.textAmmo.text = GameManager.Instance.ammo.ToString();
        }

        if (other.gameObject.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.health += other.gameObject.GetComponent<CureBox>().health;
            GameManager.Instance.textHealth.text = GameManager.Instance.health.ToString();
        }

        if (other.gameObject.CompareTag("LimitFloor"))
        {
            GameManager.Instance.health -= 25;
            GameManager.Instance.CheckHealth();
            GameManager.Instance.textHealth.text = GameManager.Instance.health.ToString();
            GetComponent<CharacterController>().enabled = false;
            this.gameObject.transform.position = respawn.position;
            GetComponent<CharacterController>().enabled = true;                     
        }

        if (other.gameObject.CompareTag("Objetivo"))
        {
            Destroy(other.gameObject);
            objetivo = true;
            paredes.SetBool("Bajar", true);
            naves.SetActive(true);
        }

        if (other.gameObject.CompareTag("Win"))
        {
            if (objetivo == true)
            {
                Destroy(other.gameObject);
                win = true;
            }
        }
    }
}
