using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntos : MonoBehaviour {

    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public SiguienteNivel siguienteNivel;
    public ball pelota;
    public Barra miBarra;
    public Transform bloquePapi;
    public static int misPuntos = 0 ;

    public Text textoPuntos;
    public sonidosFinPartida sonidosFinPartida;

    void actualizarMarcadorPuntos(){
        textoPuntos.text = "Puntos: " +puntos.misPuntos;    
    }

    public void GanarPuntos(){
        if(bloquePapi.childCount <= 0)
        {
            
            pelota.detenerMovimiento();
            miBarra.enabled = false;
            if (siguienteNivel.EsUltimoNivel())
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }

            sonidosFinPartida.NivelCompletado();
            siguienteNivel.ActivarCarga();
        }
        puntos.misPuntos++;
        actualizarMarcadorPuntos();
    }

	// Use this for initialization
	void Start () {
        actualizarMarcadorPuntos();
	}
	

}
