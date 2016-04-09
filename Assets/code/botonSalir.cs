using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botonSalir : MonoBehaviour {

    public bool salir;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("Salir del juego");
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("portada");
            }
            
        }	
	}
}
