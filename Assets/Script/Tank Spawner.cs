using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public FirstScript tankScript;
    public GameObject spawnedTank;
    public SpriteRenderer tankSR;
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
            // Instantiate a prefab: make this one appear
            // Intanttiate a prefab, a Vector2 or Vector3, a Quaternion: make itappear at this position and rotation
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            Vector2 spawnPos = Random.insideUnitCircle * 3;
            //Quaternion.identity means no rotation
            spawnedTank = Instantiate(tankPrefab, spawnPos, Quaternion.identity);
            tankScript = spawnedTank.GetComponent<FirstScript>();
            tankSR = spawnedTank.GetComponent<SpriteRenderer>();

            howManyTanks += 1;

            tankScript.speed = howManyTanks;
       
            //Instantiate a prefab, a Transform: makes it appear at 0, 0, as the child of that transformation

        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            
            Instantiate(tankPrefab, transform);


            //Instantiate a prefab, a Transform: makes it appear at 0, 0, as the child of that transformation

        }
    }
}
