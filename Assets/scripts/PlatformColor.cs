using UnityEngine;
using System.Collections;

public class PlatformColor {

    public Color32 color;
    public bool isActive;

    public PlatformColor(Color32 newColor)
    {
        color = newColor;
        isActive = false;
    }

    public void setActive(bool newBool)
    {
        isActive = newBool;
    }
}