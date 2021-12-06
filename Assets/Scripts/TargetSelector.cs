using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetSelector : MonoBehaviour
{
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                var planet = hitInfo.collider.gameObject.GetComponent<Planet>();
                if (planet != null && planet.active == true)
                {
                    int sceneNumber = planet.sceneNumber;
                    SceneManager.LoadScene(sceneNumber);
                }
            }
        }
    }
}
