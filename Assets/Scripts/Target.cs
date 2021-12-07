using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Renderer Rrenderer;
    public bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        Rrenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (active)
            Rrenderer.material.color = Color.green;
        else
            Rrenderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        Rrenderer.material.color = Color.white;
    }
}
