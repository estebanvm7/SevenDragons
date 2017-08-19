using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour {

	// Use this for initialization
	void Start () {


		for (int x = 0; x < 103; x++) {
			for (int y = 0; y < 103; y++) {
				generarCarta(x,y);
			}

		}
		// generarCarta(0,0);
		// generarCarta(0,1);
		//
		// generarCarta(51,50);
		// generarCarta(51,51);
		// generarCarta(51,52);
		//
		//
		// generarCarta(50,51);
		// //generarCarta(49,51);


	}

	// Update is called once per frame
	void Update () {

	}

//####################################################

private Carta[,] tablero = new Carta[103, 103];
//private Vector3 offsetCarta = new Vector3(2.0f, 0.00f, 2.0f);
private Vector3 offsetTablero = new Vector3(-102.00f, 0.00f, 153.0f);

public GameObject carta;

private void generarCarta(int x, int y) {
		GameObject go = Instantiate(carta) as GameObject;
		go.transform.SetParent(transform);
		Carta c = go.GetComponent<Carta>();
		tablero[x, y] = c;
		moverCarta(c, x, y);
	}

	private void moverCarta(Carta c, int x, int y) {
			c.transform.position = (Vector3.right * y * 2.0f) + (Vector3.forward * -x * 3.0f) + offsetTablero;
		}


}
