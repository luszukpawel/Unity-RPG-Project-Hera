using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject PlayerTransform;
    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = PlayerTransform.transform.position;
    }
}
