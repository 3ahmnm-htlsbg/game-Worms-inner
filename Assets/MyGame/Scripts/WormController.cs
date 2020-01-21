using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;

    void Start() {
        
        if(x>0)
        {
            Debug.Log("x is bigger than 0");

        }
        else
        {
            Debug.Log("x is smaller than 0");

        }

    if (text == "UwU")
    {
        Debug.Log("UwU means 'I love You' in Dinosaur.");
    }
        
    }




}
