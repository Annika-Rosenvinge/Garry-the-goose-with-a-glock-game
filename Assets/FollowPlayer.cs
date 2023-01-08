using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour{
    public Transform player;
    public float speed;
    public Vector3 locationOffset;
    public Vector3 rotationOffset;
    // Start is called before the first frame update
    void Start(){
        speed = 0.125f;
    }

    // Update is called once per frame
    void Update(){
        Vector3 desiredPos = player.position + player.rotation * locationOffset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, speed);
        transform.position = smoothedPos;

        Quaternion desiredRot = player.rotation * Quaternion.Euler(rotationOffset);
        Quaternion smoothedRot = Quaternion.Lerp(transform.rotation, desiredRot, speed);
        transform.rotation = smoothedRot;
    }
}
