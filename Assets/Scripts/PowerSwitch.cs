using UnityEngine;

public class PowerSwitch : MonoBehaviour
{
    float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spin = transform.eulerAngles;
        spin.z += speed * Time.deltaTime;
        transform.eulerAngles = spin;
    }

    public void StartSpin()
    {
        speed = 100;
    }

    public void StopSpin()
    {
        speed = 0;
    }
}
