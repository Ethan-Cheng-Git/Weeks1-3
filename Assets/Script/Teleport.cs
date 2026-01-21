using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float t;
    public int posRand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        t += 0.1f;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
       // if (t >= 3)
       // {
      //      newPos = (Vector2)transform.position + Random.x;
      //      t = 0;
      //  }
    }
}
