using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the mouse button is clicked
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //spawn the Prefab
            Instantiate(tankPrefab);
        }
    }
}
