﻿using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float speed;

	//apenas destroi a animacao explosao
	void Start () {
		Destroy(this.gameObject, speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
