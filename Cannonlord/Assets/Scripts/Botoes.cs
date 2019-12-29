using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    public GameObject projetil;
    public float power;
    public Transform firepoint;
    public Transform firepoint2;
    public Transform firepoint3;
    public float cooldownTime;
    float time;
    float time2;
    private bool press;
    public static bool up;

    public GameObject iniciar;
    public GameObject pause;
    public GameObject continuar;
    public GameObject atirar;

    void Awake()
    {
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        press = false;
        up = false;
        pause.SetActive(false);
        continuar.SetActive(false);
        atirar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(up == true)
        {
            time2 += Time.deltaTime;
            if(time2 >= 6)
            {
                up = false;
                time2 = 0;
            }
        }
        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (press == true)
            {
                if (up == false)
                {
                    press = false;
                    time = cooldownTime;
                    GameObject proj = Instantiate(projetil, firepoint.position, firepoint.rotation);
                    Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
                    rb.AddForce(firepoint.up * power, ForceMode2D.Impulse);
                }
                if (up == true)
                {
                    press = false;
                    time = cooldownTime;
                    GameObject proj = Instantiate(projetil, firepoint.position, firepoint.rotation);
                    GameObject proj2 = Instantiate(projetil, firepoint2.position, firepoint2.rotation);
                    GameObject proj3 = Instantiate(projetil, firepoint3.position, firepoint3.rotation);
                    Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
                    Rigidbody2D rb2 = proj2.GetComponent<Rigidbody2D>();
                    Rigidbody2D rb3 = proj3.GetComponent<Rigidbody2D>();
                    rb.AddForce(firepoint.up * power, ForceMode2D.Impulse);
                    rb2.AddForce(firepoint2.up * power, ForceMode2D.Impulse);
                    rb3.AddForce(firepoint3.up * power, ForceMode2D.Impulse);
                }
                
            }
        }
    }

    public void Comecar()
    {
        Time.timeScale = 1;
        pause.SetActive(true);
        iniciar.SetActive(false);
        atirar.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        atirar.SetActive(false);
        continuar.SetActive(true);
        pause.SetActive(false);
    }

    public void Continuar()
    {
        Time.timeScale = 1;
        atirar.SetActive(true);
        pause.SetActive(true);
        continuar.SetActive(false);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Atirar()
    {
        press = true;
    }
}
