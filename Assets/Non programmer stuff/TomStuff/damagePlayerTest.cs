﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision)
    { 
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<playerHealthManager>().damage(10);
        }
    }
}
