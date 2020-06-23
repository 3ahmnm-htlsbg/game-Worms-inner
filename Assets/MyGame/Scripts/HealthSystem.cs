
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 10;


    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            health = health - 1;

        }
       

        if (collision.gameObject.tag == "HealthPack")
        {
            health = health + 2;
            Debug.Log("Healthpack!");
        }
        else
        {
            Debug.Log("no Kollisison with Healthpack");
        }

        if (health <= 0)
        {
            Debug.Log(health);

        }
        }

    }



