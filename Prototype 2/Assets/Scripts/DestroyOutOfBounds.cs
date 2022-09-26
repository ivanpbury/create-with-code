using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float bottomBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy objects that have left the camera view
        if (transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
