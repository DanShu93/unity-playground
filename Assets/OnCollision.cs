﻿using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.ToString());
    }
}
