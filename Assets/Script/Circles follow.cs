using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Circlesfollow : MonoBehaviour
{
    //declare the public variables especially the start and end points
    public Transform start;
    public Transform end;
    public float t = 0;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the circles touches the end point then the circles restart to original start position
        t += Time.deltaTime / 2;
        if (t > 1)
        {
            t = 0;
        }
        //enables the positions of the circles path and within the time
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
