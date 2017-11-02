using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

	public GameObject vistaJugador;
	public int velocidad;

	private float posicion;

	// Use this for initialization
	void Start () {
		velocidad = 300;
	}
	
	// Update is called once per frame
	void Update () {
		
		vistaJugador = GameObject.FindGameObjectWithTag ("VistaJugador");


		if (Input.GetKey (KeyCode.RightArrow) || (Input.mouseScrollDelta.x < 0)) {

			if (vistaJugador.transform.position.x < 530) {
				Vector3 vectorDerecha = new Vector3 (velocidad * Time.deltaTime, 0, 0);

				transform.Translate (vectorDerecha);
				vistaJugador.transform.Translate (vectorDerecha);
			}
				
		}

		if (Input.GetKey (KeyCode.LeftArrow) || (Input.mouseScrollDelta.x > 0)) {

			if (vistaJugador.transform.position.x > -530) {

				Vector3 vectorIzquierda = new Vector3 (-velocidad * Time.deltaTime, 0, 0);

				transform.Translate (vectorIzquierda);
				vistaJugador.transform.Translate (vectorIzquierda);
			}

		}

		if (Input.GetKey (KeyCode.UpArrow) || (Input.mouseScrollDelta.y > 0)) {

			if (vistaJugador.transform.position.y < 700) {

				Vector3 vectorArriba = new Vector3 (0, velocidad * Time.deltaTime, 0);

				transform.Translate (vectorArriba);
				vistaJugador.transform.Translate (vectorArriba);
			}

		}

		if (Input.GetKey (KeyCode.DownArrow) || (Input.mouseScrollDelta.y < 0)) {

			if (vistaJugador.transform.position.y > -850) {

				Vector3 vectorAbajo = new Vector3 (0, -velocidad * Time.deltaTime, 0);

				transform.Translate (vectorAbajo);
				vistaJugador.transform.Translate (vectorAbajo);
			}

		}
		
	}
}
