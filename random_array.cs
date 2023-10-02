using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_array : MonoBehaviour
{
  // Start is called before the first frame update
  int min = 0;
  int max = 26;
  int[] array = new int[20];
  void Start()
  {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Random.Range(min, max);
    }
  }

  void NewNumber()
  {
    int origin = Random.Range(0, array.Length);
    array[origin] = Random.Range(min, max);
  }
  // Update is called once per frame
  void Update()
  {
    NewNumber();
    string output = "";
    foreach (int value in array)
    {
      if (value >= 15)
      {
        output += value.ToString() + " ";
      }
    }
    Debug.Log(output);
  }
}
