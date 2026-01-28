using UnityEngine;
using UnityEngine.InputSystem;

public class Trianglefollowme : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //triangle follows mouse by transforming to the world space 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos.z = 0;
        transform.position = mousePos;
    }
}
