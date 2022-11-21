using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanControl : MonoBehaviour
{
    [SerializeField]
    private Animator animator;      
    private float inputZ;   
    public float moveSpeed;
   
    // Update is called once per frame
    void Update()
    {
        inputZ = Input.GetAxis("Vertical");
        //Animation
        if ( inputZ==0)
        {
            animator.SetBool("walk",false);
        }
        else
        {
            animator.SetBool("walk", true);
        }

        //Inputs

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * moveSpeed;
        }
       
        if (Input.GetKey(KeyCode.RightArrow))
        {            
            transform.Rotate(0, 1f, 0, Space.Self);
        }
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {           
            transform.Rotate(0, -1f, 0, Space.Self);
        }

    }
   

   
}
