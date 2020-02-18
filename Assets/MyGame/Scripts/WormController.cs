using UnityEngine;

public class WormController : MonoBehaviour
{
 
    public float thrust = 20.0f;
    public Rigidbody rb;
    public Rigidbody projectile;

   void Update()
    {

        
        if (Input.GetKey(KeyCode.D)){

            Vector3 direction = new Vector3(1,0,0);
            rb.AddForce(direction * thrust);
        }

        
        if (Input.GetKey(KeyCode.A)){
        
             Vector3 direction = new Vector3(-1,0,0);
            rb.AddForce(direction * thrust);
        }

         if (Input.GetKey(KeyCode.W)){
        
             Vector3 direction = new Vector3(0,1,0);
            rb.AddForce(direction * thrust);
        }
  

   

    
    
       
    
   
}
    

     
}









