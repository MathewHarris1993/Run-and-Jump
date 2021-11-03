using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //set player rigidbody component variable
    private Rigidbody playerRb;

    void Start()
    {
        //tie the playerRb component variable to component 
        playerRb = GetComponent<Rigidbody>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
