using UnityEngine;
using System.Collections;

public class sonidosFinPartida : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;
    
    public void GameOver()
    {
        reproducir(gameOver);
    }

    public void NivelCompletado()
    {
        reproducir(completado);
    }
    

    void reproducir(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.loop = false;
        audioSource.Play();
    }
}
