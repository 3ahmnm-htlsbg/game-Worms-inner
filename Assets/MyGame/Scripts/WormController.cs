using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WormController : MonoBehaviour
{
 
    public float thrust = 20.0f;
    public float jump = 400.0f;
    public Rigidbody rb;
    public Rigidbody Projectiles;

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
            ShootBall();
        }

    }

    private void ShootBall()
    {
        
        Vector3 BulletPos = rb.transform.position + new Vector3(1, 0, 0);

        Rigidbody newbullet = Instantiate(Projectiles, BulletPos, Quaternion.identity);

        Rigidbody ballRigid = newbullet.GetComponent<Rigidbody>();

        ballRigid.AddForce(transform.right * jump);
    }

   
}
    

     










