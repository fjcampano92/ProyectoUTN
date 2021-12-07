using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipEstructure : MonoBehaviour
{
    public Image barraDeVida;

    public float vidaActual = 100;
    public float vidaMaxima = 100;
    public float timeChangeScene = 2.0f;

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        if(vidaActual <= 0)
        {
            Invoke("OnDestroy", timeChangeScene);
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("0");
    }

}
