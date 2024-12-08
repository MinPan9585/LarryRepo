using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public Ladder Ladder;
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
            Ladder.raiseLevel = 3;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Sign.SetActive(false);
    }
}
