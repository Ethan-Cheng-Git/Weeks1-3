using UnityEditor.Rendering;
using UnityEngine;

public class PulsingSources : MonoBehaviour
{
    //declare and initialize variables 
    public AnimationCurve curve;
    public float t = 0;
    public float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the time reaches 1, then the pulse restarts 
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        //Evaluate the curve within the time
        y = curve.Evaluate(t);  
        transform.localScale = Vector3.one * curve.Evaluate(t); 
    }
}
