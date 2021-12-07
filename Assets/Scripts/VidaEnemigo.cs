using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float PuntosVida;
    public float VidaMaxima = 5;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        PuntosVida = VidaMaxima;
    }

    public void TakeHit(float golpe)
    {
        PuntosVida -= golpe;
        if(PuntosVida <= 0)
        {
            GameObject effect = Instantiate(explosion);
            effect.transform.position = transform.position;
            Invoke("Destroyer", 1);
        }
    }

    public void Destoyer()
    {
        Destroy(gameObject);
    }
}
