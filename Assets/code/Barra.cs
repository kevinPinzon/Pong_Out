﻿using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

    public float velocidad = 0.4f;
    Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
	}

    public void Reset() {
        transform.position = posicionInicial;
    }
	
	// Update is called once per frame
	void Update () {
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal *velocidad*Time.deltaTime);
        if (posX < -7.84) posX = -7.84f;
        if (posX > 8) posX = 8f;
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        //transform.position = new Vector3(Mathf.Clamp(posX,-8,8), transform.position.y, transform.position.z);
    }
}
