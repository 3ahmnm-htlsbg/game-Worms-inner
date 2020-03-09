using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WormController : MonoBehaviour
{
 
    public float thrust = 20.0f;
    public float jump = 400.0f;
    public float shoot = 50.0f;
    public Rigidbody rb;
    public Rigidbody Projectiles;

    public GameObject Gun;
    public Transform ProjectilesPosition;

    public GameObject Sphere;

   private void Update()
    {

        
        if (Input.GetKey(KeyCode.D)){

            Vector3 direction = new Vector3(1,0,0);
            rb.AddForce(direction * thrust);
        }

        
        if (Input.GetKey(KeyCode.A)){
        
             Vector3 direction = new Vector3(-1,0,0);
            rb.AddForce(direction * thrust);
        }

         if (Input.GetKeyDown(KeyCode.W)){
        
             Vector3 direction = new Vector3(0,1,0);
            rb.AddForce(direction * jump);
        }

      if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
         if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Q is to rotate left");
                Gun.transform.Rotate(0, 0, -10, Space.Self);
            }

        
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E is to rotate right");
                Gun.transform.Rotate(0, 0, 10, Space.Self);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
             GameObject Projectiles = Instantiate(Sphere, ProjectilesPosition.position, Quaternion.identity);
             Projectiles.GetComponent<Rigidbody>().AddForce(Gun.transform.up * shoot);
            }
    }
 

   
        
   
       // DisplayHealth();
}
    

     










