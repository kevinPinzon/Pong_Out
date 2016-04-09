using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

    public float velocidadInicial = 600f;
    bool enJuego=false;
    Rigidbody rig;
    Vector3 posicionInicial;
    public Transform barra;
    public elementosInteractivo pantalla;


    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        detenerMovimiento();
    }

    public void detenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Use this for initialization
    void Start () {
        posicionInicial = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (!enJuego && (Input.GetButtonDown("Fire1") || pantalla.pulsado))
        {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic=false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));

        }
	}
}
