using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] PanelsController panelsController;

    public TextMeshProUGUI textAmmo;
    public TextMeshProUGUI textHealth;
    public int ammo = 50;
    public int health = 100;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        textAmmo.text = ammo.ToString();
        textHealth.text = health.ToString();
    }

    public void CheckHealth()
    {
        if (health <= 0)
        {
            panelsController.Lose = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
