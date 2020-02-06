using UnityEngine;

public class WormController : MonoBehaviour
{
 

   void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)){

           // Worm(transform.position);
        }
        
        if (Input.GetKeyDown("space")){
        
            print("space key was pressed");
        }
  
         if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    Start();

    void FixedUpdate(){
        rb.AddForce(transform.forward * thrust);
    }
    FixedUpdate();
}
    public float thrust = 1.0f;
    public Rigidbody rb;
    public Rigidbody projectile;

}






