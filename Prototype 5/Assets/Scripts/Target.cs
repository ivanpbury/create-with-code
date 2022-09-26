using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRb;

    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float torque = -10;
    private float xRange = 4;
    private float ySpawnPos = -3;
    private GameManager manager;
    public int points;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnPos();

        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        manager.UpdateScore(points);
        Instantiate(explosion, transform.position, explosion.transform.rotation);
        if (gameObject.CompareTag("Bad"))
        {
            manager.gameActive = false;
            manager.gameOverText.SetActive(true);
            manager.restartButton.SetActive(true);
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    Vector3 RandomTorque()
    {
        return new Vector3(Random.Range(-torque, torque), Random.Range(-torque, torque), Random.Range(-torque, torque));
    }    
}
