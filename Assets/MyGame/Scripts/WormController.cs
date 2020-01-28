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

    if (text == "help")
    {
        Debug.Log("I will not help you, sorry.");
    }

    if (x<10)
{
  Debug.Log("x is smaller than 10, how bad."); 
}
else
{
    Debug.Log("x is 10 or over 10, how amazing!"); 
}
        
    }









}
