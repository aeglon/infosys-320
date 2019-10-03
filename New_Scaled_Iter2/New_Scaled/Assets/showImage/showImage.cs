﻿using UnityEngine;
using UnityEngine.UI;

public class showImage : MonoBehaviour
{

    public RawImage image;

    void Start()
    {
        // Turns the image off.
        image.enabled = false;
    }

    void OnMouseDown()
    {
        // Turns the image on if it is off, and off if it is on.
        image.enabled = !image.enabled;
    }
}