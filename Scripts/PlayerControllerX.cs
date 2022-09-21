using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //time the player waits to spawn dog again
    private float fireRate = 1;
    //time of start when player can spawn(fire) dog again
    private float nextFire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if the time has elasped since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            //reset nextFire(spawn) to current time + fireRate
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
