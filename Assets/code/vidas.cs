using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vidas : MonoBehaviour {

    public static int numVidas = 3;//variable global en todo el juego 
    public Text textoVidas;
    public ball myBall;
    public Barra miBarra;
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;
    public sonidosFinPartida sonidosFinPartida;
    public AudioSource perderVida;

    // Use this for initialization
    void Start () {
        actualizarMarcadorVidas();
	}

    void actualizarMarcadorVidas(){
        textoVidas.text = "Vidas: " + numVidas;
    }
	
    public void perderVidas(){
        if (numVidas <= 0) return;
        numVidas--;
        actualizarMarcadorVidas();

        if (numVidas <= 0)
        {
            sonidosFinPartida.GameOver();
            gameOver.SetActive(true);
            myBall.detenerMovimiento();
            miBarra.enabled = false;
            //miBarra.gameObject.SetActive(false);
            siguienteNivel.nivelAcargar = "portada";
            siguienteNivel.ActivarCarga();

        }else
        {

            perderVida.Play();
            miBarra.Reset();
            myBall.Reset();
        }


    }
}
