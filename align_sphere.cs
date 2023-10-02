using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class align_sphere : MonoBehaviour
{
    public Transform sphere;
    public float xOffset = 5f; 


    void Start()
    {
        sphere = GameObject.FindWithTag("Sphere").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 referencePosition = sphere.position;
        Vector3 newPosition = new Vector3(referencePosition.x + xOffset, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}

