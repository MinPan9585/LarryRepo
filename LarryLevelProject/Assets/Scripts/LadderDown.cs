using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderDown : MonoBehaviour
{
    public int raiseLevel;
    public Rigidbody rb;
    public GameObject Ladder;
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
        if (other.gameObject.tag == "Player")
        {
            Elevate();
        }
    }
    private void Elevate()
    {
         if (Ladder.transform.position.y >= 8.7f)
         {
                rb.velocity = Vector3.down;
         }
         else
         {

                rb.velocity = Vector3.zero;
          }

        
    }
    }
