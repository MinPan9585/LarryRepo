using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public Rigidbody rb;
    public int raiseLevel;
    public int direction;
    // Start is called before the first frame update
    private void Awake()
    {
        direction = 1;
        rb = GetComponent<Rigidbody>();
        raiseLevel = 2;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Elevate();
        }
    }
    private void Elevate()
    {
       
            if (this.transform.position.y <= 16 && raiseLevel == 2)
            {
                rb.velocity = direction * Vector3.up;
            }
            else if (raiseLevel == 3 && this.transform.position.y <= 43f)
            {
                rb.velocity = Vector3.up;
            }
            else
            {

                rb.velocity = Vector3.zero;
            
            }
            
        
    }
    private void OnTriggerExit(Collider other)
    {
        rb.velocity = Vector3.zero;
    }
}
