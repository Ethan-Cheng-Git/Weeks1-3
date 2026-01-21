using UnityEngine;

public class DirectionalMovement : MonoBehaviour
{

    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Vector2 newPos = transform.position;
       // newPos.x += speed * Time.deltaTime;
        //transform.right is like the new Vector3(1, 0, 0)
        //transform.up is like Vector3(0, 1, 0)
        //transform.foward is like Vector3(0, 0, 1) NO USE IN 2D
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
