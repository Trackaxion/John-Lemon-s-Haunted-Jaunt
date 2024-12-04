using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public CanvasGroup mapCanvasGroup;
    void Start()
    {
        mapCanvasGroup.alpha = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            mapCanvasGroup.alpha = 0;
    }
}