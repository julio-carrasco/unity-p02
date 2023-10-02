using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_manager : MonoBehaviour
{
    public GameObject cube;
    public GameObject[] spheres;

    private Transform closestSphere;
    private Transform furthestSphere;

    private void Start()
    {
        cube = GameObject.FindWithTag("Cube");
        GameObject[] aloneSpheres = GameObject.FindGameObjectsWithTag("Alone");
        GameObject[] groupedSpheres = GameObject.FindGameObjectsWithTag("Grouped");
        spheres = new GameObject[aloneSpheres.Length + groupedSpheres.Length];
        aloneSpheres.CopyTo(spheres, 0);
        groupedSpheres.CopyTo(spheres, aloneSpheres.Length);

        FindClosestAndFurthestSpheres();
        if (closestSphere != null)
        {
            Vector3 newPosition = closestSphere.position;
            newPosition.y += 2f;
            closestSphere.position = newPosition;
        }
        if (furthestSphere != null)
        {
            Renderer furthestRenderer = furthestSphere.GetComponent<Renderer>();
            if (furthestRenderer != null)
            {
                furthestRenderer.material.color = Color.red;
            }
        }
    }
    private void Update()
    {

    }

    private void FindClosestAndFurthestSpheres()
    {
        float closestDistance = Mathf.Infinity;
        float furthestDistance = 0f;
        foreach (GameObject sphere in spheres)
        {
            float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestSphere = sphere.transform;
            }
            if (distance > furthestDistance)
            {
                furthestDistance = distance;
                furthestSphere = sphere.transform;
            }
        }
    }
}
