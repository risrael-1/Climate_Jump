using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Const : MonoBehaviour
{
    public static float screenLimitX, screenLimitY;

    void Awake()
    {
        Camera cam;
        cam = Camera.main;
        screenLimitX = cam.orthographicSize * cam.aspect;
        screenLimitY = cam.orthographicSize;
    }

    int Addition(int n1, int n2)
    {
        return n1 + n2;
    }
}
