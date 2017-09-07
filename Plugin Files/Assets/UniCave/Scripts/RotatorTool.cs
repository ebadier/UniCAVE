﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles the rotation of an object.
/// </summary>
public class RotatorTool : MonoBehaviour, ITool {
    public GameObject wandObject;
    public GameObject holder;
    RaycastHit refHit;


    /// <summary>
    /// Rotates the object when the user has selected it
    /// </summary>
    /// <param name="hit"></param>
    /// <param name="offset"></param>
    /// <param name="origin"></param>
    /// <param name="direction"></param>
    public void ButtonDrag(RaycastHit hit, Vector3 offset, Vector3 origin, Vector3 direction)
    {
        if(refHit.collider == null)
        {
            refHit = hit;            
        }

        hit.transform.rotation = wandObject.transform.rotation;

    }

    // Use this for initialization
    void Start () {
        //Get all necessary game objects
        if (wandObject == null)
        {
            Debug.LogError("Need to set wand object!");
        }

        if (holder == null)
        {
            Debug.LogError("Need to set top level UniCAVE object!");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void init()
    {
        throw new NotImplementedException();
    }

    public void shutDown()
    {
        refHit = new RaycastHit();
    }

    public void Analog(double x, double y)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Handles button down event - does nothing right now.
    /// </summary>
    /// <param name="buttonNum">The button pressed</param>
    /// <param name="origin">The position of the tracker</param>
    /// <param name="direction">The forward direction of the tracker</param>
    /// <param name="hit">The object hit with raycast.</param>
    public void ButtonDown(TrackerButton buttonNum, Vector3 origin, Vector3 direction, RaycastHit hit)
    {

    }
    public void ButtonClick(TrackerButton button, Vector3 origin, Vector3 direction)
    {

    }

    /// <summary>
    /// Name of the tool - Rotate tool.
    /// </summary>
    public string ToolName
    {
        get
        {
            return "Rotator";
        }
    }
}
