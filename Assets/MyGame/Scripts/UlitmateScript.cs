
using System.Reflection;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UlitmateScript : MonoBehaviour
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
public Text HealthText;
public int health;




 void Start()
    {
        HealthText.text = health.ToString();
    }


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



         void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "projectile")
        {
            health = health - 1;
            Debug.Log("collision with Projectile");
            HealthText.text = health.ToString();
        }
        else if (collision.gameObject.tag == "HealthPack")
        {
            health = health + 2;
            Debug.Log("Healthpack");
            HealthText.text = health.ToString();
            Destroy(collision.gameObject);
        }
        
        else
        {
            Debug.Log("no collision with anything");
            HealthText.text = health.ToString();
        }
    }

OnCollisionEnter();



    }

}
