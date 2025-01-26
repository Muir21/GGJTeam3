using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f,4f,-10f);
    private float smoothness = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform player;

   
    void Update()
    {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothness);
    }
}
