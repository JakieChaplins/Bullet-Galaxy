using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class PanelsController : MonoBehaviour
{
    [SerializeField] PlayerActions PlayActs;

    [SerializeField] private AudioMixer audioMixer;

    public Slider slider;

    public GameObject playerCharacter;

    public bool Paused;
    public bool Win;
    public bool Lose;
    public bool Menu;

    public GameObject[] MenusPausaOpciones;

    void Start()
    {
        playerCharacter.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        Paused = true;
        Win = false;
        Lose = false;
        Menu = true;
        MenusPausaOpciones[0].SetActive(true);
        MenusPausaOpciones[1].SetActive(false);
        MenusPausaOpciones[2].SetActive(false);
        MenusPausaOpciones[3].SetActive(false);
        MenusPausaOpciones[4].SetActive(false);
        MenusPausaOpciones[5].SetActive(true);
    }

    void Update()
    {
        if (Win == false && Lose == false && Menu == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Paused == false)
                {
                    playerCharacter.SetActive(false);
                    MenusPausaOpciones[1].SetActive(true);
                    Time.timeScale = 0;
                    Paused = true;
                    Cursor.lockState = CursorLockMode.None;            
                }
                else
                {
                    playerCharacter.SetActive(true);
                    Cursor.lockState = CursorLockMode.Locked;
                    MenusPausaOpciones[2].SetActive(false);
                    MenusPausaOpciones[1].SetActive(false);
                    Time.timeScale = 1;
                     Paused = false;
                }
            }
        }

        if (Lose == true)
        {
            playerCharacter.SetActive(false);
            MenusPausaOpciones[3].SetActive(true);
            Time.timeScale = 0;
            Paused = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (PlayActs.win == true)
        {
            Win = true;
            playerCharacter.SetActive(false);
            MenusPausaOpciones[4].SetActive(true);
            Time.timeScale = 0;
            Paused = true;
            Cursor.lockState = CursorLockMode.None;
            PlayActs.win = false;
        }
    }

    public void PlayArcade()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Time.timeScale = 1;
        Paused = false;
    }

    public void PlayCampaing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        Paused = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void CambiarVolumen(float sliderValue)
    {
        Debug.Log(slider.value);
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        Debug.Log(slider.value);
    }

    public void ReanudarBoton()
    {
        playerCharacter.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        MenusPausaOpciones[2].SetActive(false);
        MenusPausaOpciones[5].SetActive(false);
        MenusPausaOpciones[1].SetActive(false);
        Time.timeScale = 1;
        Paused = false;
        Menu = false;
    }

    public void OpcionesBoton()
    {
        MenusPausaOpciones[2].SetActive(true);
        if (Menu == true)
        {
            MenusPausaOpciones[0].SetActive(false); 
        }
        else if (Win == true)
        {
            MenusPausaOpciones[4].SetActive(false);
        }
        else if (Lose == true)
        {
            Lose = false;
            MenusPausaOpciones[3].SetActive(false);           
        }
        else if (Win == false && Lose == false)
        {
            MenusPausaOpciones[1].SetActive(false);
        }
    }

    public void VolverBoton()
    {
        MenusPausaOpciones[2].SetActive(false);
        if (GameManager.Instance.health <= 0)
        {
            MenusPausaOpciones[3].SetActive(true);
            Lose = true;
        }    
        else if (Win == true)
        {
            MenusPausaOpciones[4].SetActive(true);
        }       
        else if (Menu == true)
        {
            MenusPausaOpciones[0].SetActive(true); 
            //MenusPausaOpciones[3].SetActive(true);
            //Lose = true;
        }
        else if (Win == false && Lose == false)
        {
            MenusPausaOpciones[1].SetActive(true);
        }
    }

    public void MenuBoton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Win = false;
        Lose= false;
        Time.timeScale = 1;
    }
}
