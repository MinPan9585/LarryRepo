using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching : MonoBehaviour
{
    public GameObject Sign;
    public Ladder Ladder;
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
            Ladder.direction = -Ladder.direction;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sign.SetActive(false);
    }
}
