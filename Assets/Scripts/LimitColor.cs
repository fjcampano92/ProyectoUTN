using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitColor : MonoBehaviour
{
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("si toca");
            renderer.material.color = Color.red;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("si toca");
            renderer.material.color = Color.red;
        }
    }
}
