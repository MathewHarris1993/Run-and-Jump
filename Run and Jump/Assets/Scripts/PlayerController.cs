using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;

    //set player rigidbody component variable
    private Rigidbody playerRb;

    void Start()
    {
        //tie the playerRb component variable to component 
        playerRb = GetComponent<Rigidbody>();

        //create access to gravity physics through the variable gravityModifier
        Physics.gravity *= gravityModifier;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {

            //allow player to jump when on ground and player pushes space
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

        }
   }
 private void OnCollisionEnter(Collision collision)
    {
        //reset isOnGround variable to true once player lands
        isOnGround = true;

    }

}
