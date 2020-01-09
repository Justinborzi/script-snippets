using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2.1f;
    int current = 1;
    readonly float wPradius = 1f;

    void FixedUpdate()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
