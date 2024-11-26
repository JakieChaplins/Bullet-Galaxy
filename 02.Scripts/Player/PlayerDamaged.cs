using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    public AudioSource hurt;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("damage"))
        {
            GameManager.Instance.health -= 15;
            GameManager.Instance.CheckHealth();
            GameManager.Instance.textHealth.text = GameManager.Instance.health.ToString();
            hurt.Play();
        }
    }
}
