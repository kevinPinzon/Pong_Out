using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SiguienteNivel : MonoBehaviour {

    public string nivelAcargar;
    public float retraso;


	public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        SceneManager.LoadScene(nivelAcargar);
    }

    public bool EsUltimoNivel()
    {
        if(nivelAcargar == "portada")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
