using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color_a : MonoBehaviour
{
    public KeyCode keyToPress = KeyCode.A;
    public Color targetColor = Color.blue;

    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            objectRenderer.material.color = targetColor;
        }
    }
}
