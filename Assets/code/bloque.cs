using UnityEngine;
using System.Collections;

public class bloque : MonoBehaviour {

    public GameObject efectoParticulas;
    public puntos misPuntos;

    //IS trigger DESACTIVADO
    void OnCollisionEnter(){
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        misPuntos.GanarPuntos();
    }

    /*  SEGUNDO TIPO DE COLLISION
    // IS trigger ACTIVADO
    void OnTriggerEnter(){
        Debug.Log("triggerEnter");
    }
    */
}
