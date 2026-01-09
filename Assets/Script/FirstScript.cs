using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public float speed = 0.01f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x += 0.01f;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < -9 || screenPos.x > Screen.width)
        {
            speed = speed * -1;

        }
    }
}
