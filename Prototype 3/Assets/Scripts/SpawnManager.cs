using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private float startDelay = 2;
    private float interval = 2;
    public GameObject obstacle;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("spawnObstacle", startDelay, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstacle, new Vector3(25, 0, 0), obstacle.transform.rotation);
        }
        
    }
}
