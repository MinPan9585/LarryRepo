using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public GameObject Sign;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        Sign.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.localScale = new Vector3(500f, this.transform.localScale.y,this.transform.localScale.z); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sign.SetActive(false);
    }
}
