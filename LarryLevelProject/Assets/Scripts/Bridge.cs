using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
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
            this.transform.Rotate(40f, 0f, 0f);
            this.transform.position -= new Vector3(0, 4, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sign.SetActive(false);
    }
}
