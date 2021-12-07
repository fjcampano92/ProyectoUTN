using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public float velocidad = 10.0f;
    private Rigidbody rb;
    private float h, v;

    [SerializeField]
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //Movimiento
        rb.velocity = (h * Vector3.right + v * Vector3.forward) * velocidad;

        // Apuntar a donde nos movemos.
        //Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mouseWorldPosition.z = 0;
        //Vector3 lookAtDirection = mouseWorldPosition - target.position;
        //target.right = lookAtDirection;
        //var vel = rb.velocity;
        //vel.y = 0.0f;
        //if (vel.magnitude > 0.1f)
        //{
        //    var dirMov = rb.velocity.normalized;
        //    rb.rotation = Quaternion.LookRotation(dirMov, Vector3.up);
        //}
    }
}
