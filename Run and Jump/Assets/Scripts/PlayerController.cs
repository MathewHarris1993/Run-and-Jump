using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;


    //set player rigidbody component variable
    private Rigidbody playerRb;
    private Animator playerAnim;


    void Start()
    {
        //tie the playerRb component variable to component 
        playerRb = GetComponent<Rigidbody>();

        //create access to gravity physics through the variable gravityModifier
        Physics.gravity *= gravityModifier;

        playerAnim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {

            //allow player to jump when on ground and player pushes space
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");

        }
   }
 private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("Fence"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);


        }
        //reset isOnGround variable to true once player lands
        

    }

}
