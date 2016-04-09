using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class empezarPartida : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            vidas.numVidas = 3;
            puntos.misPuntos = 0;
            SceneManager.LoadScene("nivel01");
        }
	
	}
}
