using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

	public GameObject vistaJugador;
	public int velocidad;
	//	private int limiteAriba;
	//	private int limiteAbajo;
	//	private int limiteDerecha = 100;
	//	private int limiteIzquierda = 100;
	//private float posicion;

	// Use this for initialization
	void Start () {
		velocidad = 300;
	}
	
	// Update is called once per frame
	void Update () {
		
		vistaJugador = GameObject.FindGameObjectWithTag ("VistaJugador");


		if (Input.GetKey (KeyCode.RightArrow) || (Input.mouseScrollDelta.x < 0)) {

//			posicion = velocidad * Time.deltaTime;
//
//			posicion = Mathf.Clamp (posicion, limiteIzquierda, limiteDerecha);

			//Vector3 vectorDerecha = new Vector3 ( posicion, 0, 0);


			Vector3 vectorDerecha = new Vector3 (velocidad * Time.deltaTime, 0, 0);

			transform.Translate (vectorDerecha);
			vistaJugador.transform.Translate (vectorDerecha);

		}

		if (Input.GetKey (KeyCode.LeftArrow) || (Input.mouseScrollDelta.x > 0)) {

			Vector3 vectorIzquierda = new Vector3 (-velocidad * Time.deltaTime, 0, 0);

			transform.Translate (vectorIzquierda);
			vistaJugador.transform.Translate (vectorIzquierda);

		}

		if (Input.GetKey (KeyCode.UpArrow) || (Input.mouseScrollDelta.y > 0)) {

			Vector3 vectorArriba = new Vector3 (0, velocidad * Time.deltaTime, 0);

			transform.Translate (vectorArriba);
			vistaJugador.transform.Translate (vectorArriba);

		}

		if (Input.GetKey (KeyCode.DownArrow) || (Input.mouseScrollDelta.y < 0)) {

			Vector3 vectorAbajo = new Vector3 (0, -velocidad * Time.deltaTime, 0);

			transform.Translate (vectorAbajo);
			vistaJugador.transform.Translate (vectorAbajo);

		}
		
	}
}
