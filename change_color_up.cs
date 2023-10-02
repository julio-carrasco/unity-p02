using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color_up : MonoBehaviour
{
    public KeyCode keyToPress = KeyCode.UpArrow;
    public Color targetColor = Color.magenta;

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
