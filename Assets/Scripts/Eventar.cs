using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventar : MonoBehaviour
{
    public UnityEvent onMouseClicked;


    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))))
        {
            onMouseClicked?.Invoke();
        }
    }
}
