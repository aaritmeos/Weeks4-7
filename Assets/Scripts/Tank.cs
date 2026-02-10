using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    public float speed = 0.01f;
    [SerializeField] bool leftArrowIsPressed = false;
    [SerializeField] bool rightArrowIsPressed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftArrowIsPressed = Keyboard.current.leftArrowKey.isPressed;
        rightArrowIsPressed = Keyboard.current.rightArrowKey.isPressed;


       if (leftArrowIsPressed)
        {
            transform.position += transform.right * speed * -1 * Time.deltaTime;
        }

        if (rightArrowIsPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
