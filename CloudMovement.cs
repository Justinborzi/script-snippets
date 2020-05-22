// Add the required components to use in the script﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Define the Class
public class CloudMovement : MonoBehaviour
{
    // Create Properties of a Class
    public Transform[] waypoints;
    public float speed = 2.1f;
    int current = 1;
    readonly float wPradius = 1f;
    
    // Method to execute code in
    void FixedUpdate()
    {
        // Check if the distance is between 2 points
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        // Move the object
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
