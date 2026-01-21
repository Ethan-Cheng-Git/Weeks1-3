using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColouredShapes : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public float timer = 10;

    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer.color = Color.red; to set object colour to red
        
        //pickARandomSprite();
        //spriteRenderer.sprite = mySprite;   

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spriteRenderer.color = Random.ColorHSV();
            timer = 10;
        }

    }
        
            
        

}
