using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    [SerializeField] float laserOffTime = 0.5f;
    [SerializeField] float maxDistance = 300f;
    [SerializeField] float fireDelay = 2f;
    LineRenderer lr;
    bool canFire;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        lr.enabled = false;
        canFire = true;
    }

    //private void Update()
    //{
    //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * maxDistance, Color.yellow);
    //}

    Vector3 CastRay()
    {
        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward) * maxDistance;

        if(Physics.Raycast(transform.position, fwd, out hit))
        {
            Debug.Log("We hit" + hit.transform.name);
            return hit.point;
        }
        return transform.position + (transform.forward * maxDistance);
    }



    public void FireLaser()
    {
        Vector3 pos = CastRay();
        FireLaser(pos);
        //FireLaser(CastRay());
    }

    public void FireLaser(Vector3 targetPosition)
    {
        if (canFire)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, targetPosition);
            lr.enabled = true;
            canFire = false;
            Invoke("TurnOffLaser", laserOffTime);
            Invoke("CanFire", fireDelay);
        }
    }

    void TurnOffLaser()
    {
        lr.enabled = false;
    }

    public float Distance
    {
        get { return maxDistance; }
    }

    void CanFire()
    {
        canFire = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var enemigo = collision.collider.GetComponent<VidaEnemigo>();
        if (enemigo)
        {
            enemigo.TakeHit(1);
        }
    }
}
