using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
public Rigidbody rb;
public KeyCode jump;
public KeyCode left;
public KeyCode right;
public KeyCode shoot;
public Vector3 jumpForce;
public Vector3 moveForce;
public Vector3 shootSpeed;
public GameObject projectile;
public GameObject spawnPos;






    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(jumpForce);
        }

        if (Input.GetKey(left))
        {
           rb.AddForce(moveForce); 
        }

        if (Input.GetKey(right))
        {
           rb.AddForce(-moveForce);
        }

        if (Input.GetKeyDown(shoot))
        {
            //for cloning
          GameObject clone = Instantiate (projectile,spawnPos.transform.position,Quaternion.identity); 
          Rigidbody rigid = clone.GetComponent<Rigidbody>();
          rigid.AddForce(shootSpeed);
        }   
     //Right Worm


       if (Input.GetKeyDown(jump))
        {
        rb.AddForce(jumpForce);
        }

        if (Input.GetKey(left))
        {
             rb.AddForce(moveForce);
        }

        if (Input.GetKey(right))
        {
             rb.AddForce(-moveForce);
        }

        if (Input.GetKeyDown(shoot))
        {
            GameObject clone = Instantiate (projectile,spawnPos.transform.position,Quaternion.identity); 
          Rigidbody rigid = clone.GetComponent<Rigidbody>();
          rigid.AddForce(shootSpeed);
        }


        







    }

}

     










