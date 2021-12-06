using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    Target activeTrueOrFalse;
    public string nombre;
    public bool active;
    public int sceneNumber;

    private void Update()
    {
        activeTrueOrFalse = GetComponent<Target>();
        active = activeTrueOrFalse.active;
    }
}
