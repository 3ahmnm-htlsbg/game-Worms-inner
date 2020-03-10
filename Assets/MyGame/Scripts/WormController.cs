using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WormController : MonoBehaviour
{
 
    public float thrust = 20.0f;
    public float jump = 400.0f;
    public float shoot = 100.0f;
    public float shootRight = -100.0f;

    public Rigidbody rbLeft;
    public Rigidbody rbRight;

    public Rigidbody ProjectilesLeft;
    public Rigidbody ProjectilesRight;

    public GameObject GunLeft;
    public GameObject GunRight;

    public Transform ProjectilesPositionL;
    public Transform ProjectilesPositionR;

    public GameObject SphereL;
    public GameObject SphereR;

   private void Update()
    {

      //Left

        if (Input.GetKey(KeyCode.D)){

            Vector3 direction = new Vector3(1,0,0);
            rbLeft.AddForce(direction * thrust);
        }

        
        if (Input.GetKey(KeyCode.A)){
        
             Vector3 direction = new Vector3(-1,0,0);
            rbLeft.AddForce(direction * thrust);
        }

         if (Input.GetKeyDown(KeyCode.W)){
        
             Vector3 direction = new Vector3(0,1,0);
            rbLeft.AddForce(direction * jump);
        }

      if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
         if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Q is to rotate left");
                GunLeft.transform.Rotate(0, 0, -10, Space.Self);
            }

        
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E is to rotate right");
                GunLeft.transform.Rotate(0, 0, 10, Space.Self);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
             GameObject ProjectilesLeft = Instantiate(SphereL, ProjectilesPositionL.position, Quaternion.identity);
             ProjectilesLeft.GetComponent<Rigidbody>().AddForce(GunLeft.transform.up * shoot);
            }

            
             //Right
        
        if (Input.GetKey(KeyCode.RightArrow)){

            Vector3 direction = new Vector3(1,0,0);
            rbRight.AddForce(direction * thrust);
        }

        
        if (Input.GetKey(KeyCode.LeftArrow)){
        
             Vector3 direction = new Vector3(-1,0,0);
            rbRight.AddForce(direction * thrust);
        }

         if (Input.GetKeyDown(KeyCode.UpArrow)){
        
             Vector3 direction = new Vector3(0,1,0);
            rbRight.AddForce(direction * jump);
        }

      if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject ProjectilesRight = Instantiate(SphereR, ProjectilesPositionR.position, Quaternion.identity);
             ProjectilesRight.GetComponent<Rigidbody>().AddForce(GunRight.transform.up * shootRight);
        }
         if (Input.GetKeyDown(KeyCode.O))
            {
               
                GunRight.transform.Rotate(0, 0, -10, Space.Self);
            }

        
            if (Input.GetKeyDown(KeyCode.P))
            {
          
                GunRight.transform.Rotate(0, 0, 10, Space.Self);
            }
    }
 
        
   
       // DisplayHealth();
}
    

     










