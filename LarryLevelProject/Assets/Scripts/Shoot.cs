using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
    }

    void ShootRay()
    {
        // Get the center of the screen
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);

        // Convert screen center to a ray
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);

        // Store hit information
        RaycastHit hit;

        // Check if the ray hits an object
        if (Physics.Raycast(ray, out hit, 20f))
        {
            if(hit.collider.tag == "Enemy")
            {
                // Destroy the object
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
