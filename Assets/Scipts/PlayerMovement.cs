using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private float runSpeed = 40f;
    
    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetKeyDown(KeyCode.Space)){
            jump = true;
        }
    }

    void FixedUpdate(){
        playerController.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
