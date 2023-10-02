using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector : MonoBehaviour
{
  // Start is called before the first frame update
  Vector3 vec1;
  Vector3 vec2;
  void Start()
  {
    vec1 = new Vector3(1.3f, -0.5f, -1f);
    vec2 = new Vector3(-0.3f, 1.5f, 0.1f);
    transform.position = vec2;
  }

  // Update is called once per frame
  void Update()
  {
    Debug.Log("Vector magnitudes: " + vec1.magnitude + ", " + vec2.magnitude);
    Debug.Log("Angle: " + Vector3.Angle(vec1, vec2));
    Debug.Log("Distance: " + Vector3.Distance(vec1, vec2));
    Debug.Log("Vector mas alto:" + (vec1.y > vec2.y ? vec1 : vec2));
  }
}
