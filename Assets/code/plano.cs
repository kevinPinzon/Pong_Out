using UnityEngine;
using System.Collections;

public class plano : MonoBehaviour {

   public vidas misVidas;

    void OnTriggerEnter()
    {

        misVidas.perderVidas();
    }
}
