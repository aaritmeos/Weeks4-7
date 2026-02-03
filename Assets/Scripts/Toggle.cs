using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleShape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //if the game object is inactive: call SetActive passing true
        //if (gameObject.activeInHierarchy == false)
        //{
            //gameObject.SetActive(true);
        //}
        //else if (gameObject.activeInHierarchy == true)
        //{
            //otherwise (the game object is active, turned on): call SetActive and pass false
            //gameObject.SetActive(false);
        //}
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
