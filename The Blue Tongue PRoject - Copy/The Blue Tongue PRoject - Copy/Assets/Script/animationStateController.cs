using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int Attack;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");
        bool isAttacking = Input.GetMouseButton(0);

        // if player presses w key THEN THIS IS HOW THE ANIMATION PLAYS
        if (!isWalking && forwardPressed)
        {
            //then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, true);
        }

        if (!isWalking && leftPressed)
        {
            //then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, true);
        }

        if (!isWalking && rightPressed)
        {
            //then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, true);
        }

        // if player is not pressing w key then THIS IS HOW THE ANIMATION STOPS
        if (isWalking && !forwardPressed)
        {
            // then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        }

        if (!isWalking && leftPressed)
        {
            //then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, false);
        }

        if (!isWalking && rightPressed)
        {
            //then set the isWalking boolean to true
            animator.SetBool(isWalkingHash, false);
        }


        //if the player is walking and not running and presses left shift 
        if (!isrunning && (forwardPressed && runPressed))
        {
            //the bou starts running and isRunning bool is set to true
            animator.SetBool(isRunningHash, true);
        }

        //if player is running and stops running or walking
        if (isrunning && (!forwardPressed || !runPressed))
        {
            //then the boy is stopping and isRunning bool is false
            animator.SetBool(isRunningHash, false);
        }

        if (isAttacking)
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack",false);
        }
    }
}