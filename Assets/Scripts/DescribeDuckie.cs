using UnityEngine;
using UnityEngine.InputSystem;

public class DescribeDuckie : MonoBehaviour
{
    //varible to connect to DescribeDuckie text
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //determine mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

       //if the mouse is over the duckie
       
        {

        }
       //call text in UI to appear
       //if mouse is not over the duckie
       //disappear text
    }
}
