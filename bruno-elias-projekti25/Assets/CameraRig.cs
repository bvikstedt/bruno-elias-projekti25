using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public Transform player;

    public float followSpeed = 5f;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, followSpeed * Time.deltaTime);
    }
}
