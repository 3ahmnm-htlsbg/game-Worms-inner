using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
 
   public int health = 10;
   public Text text;

        
      void OnCollisionEnter(Collision collision)
      {
        //tag in Unity gleich unter Name von Gameobject
     if (collision.gameObject.tag == "projectile")

    {
      health = health - 1;
      Destroy(collision.gameObject);
    }


text.text = health.ToString();

      }

    
     
         
     


    }


