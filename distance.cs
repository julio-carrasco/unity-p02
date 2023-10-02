using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    private Transform cube;
    private Transform cylinder;

    void Start()
    {
        cube = GameObject.FindWithTag("Cube").transform;
        cylinder = GameObject.FindWithTag("Cylinder").transform;
    }

    void Update()
    {
        if (cube != null && cylinder != null)
        {
            float distanceToCube = Vector3.Distance(cube.position, transform.position);
            float distanceToCylinder = Vector3.Distance(cylinder.position, transform.position);

            Debug.Log("Distance to cube: " + distanceToCube);
            Debug.Log("Distance to cylinder: " + distanceToCylinder);
        }
    }
}

