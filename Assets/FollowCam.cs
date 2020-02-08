using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI;

    [Header("Set in Inspector")]
    public float easing = 0.05f;
    

    [Header("Set Dynamically")]
    public float camZ;

    void Awake()
    {
        camZ = this.transform.position.z;
    }
    void FixedUpdate()
    {
        if (POI == null) return;

        Vector3 destination = POI.transform.position;
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
    }
}
