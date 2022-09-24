using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit and ball if z position less than bottom limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }

    }
}
