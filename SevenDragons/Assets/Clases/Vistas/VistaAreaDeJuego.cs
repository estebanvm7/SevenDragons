using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VistaAreaDeJuego : VistaJuego {

	public GameObject panel;

	private Vector3 offsetTablero = new Vector3 (-5100.0f, 7725.0f, 0.0f);

	// Use this for initialization
	void Start () {

//		int[,] matrizColores = { { 1, 1 }, { 3, 4 } };
//
//		Carta cTemp = new Carta (matrizColores);
//
//		generarCarta (51, 50, cTemp);

//		//generarPanel (51, 50);
//		//generarCarta (51, 51);
//		//generarCarta (51, 50);
//		generarPanel (51, 52);
//		//generarCarta (50, 51);
//		generarPanel (50, 51);
//		//generarCarta (52, 51);
//		generarPanel (52, 51);

		for (int i = 45; i < 59; i++) {
			for (int j = 40; j < 63; j++) {
				if (i == 51 && j == 51) {
				}
				generarPanel (i,j);
				
			}
			
		}
//
//		generarPanel (1,0);
//		generarPanel (1,1);
//
//		generarCarta (0,0, cTemp);
//		generarCarta (0,1, cTemp);


	}

	// Update is called once per frame
	void Update () {

	}

	public void generarCarta (int fila, int columna, Carta carta) {

		//obtiene el objeto adecuado con rrespecto a los colores de la carta
		GameObject go = generarGameObjetcCarta (carta);

		VistaAreaDeJuego vaj = transform.GetComponentInChildren <VistaAreaDeJuego>();
		go.transform.SetParent (vaj.transform);

		reposicionarObjeto (go, fila, columna);
	}

	private void generarPanel (int fila, int columna) {

		GameObject go = Instantiate (panel) as GameObject;

		//asigna los valores del panel
		Panel temp = go.GetComponent<Panel> ();
		temp.setX (fila);
		temp.setY (columna);


		go.transform.SetParent (transform.transform);
		reposicionarObjeto (go, fila, columna);
	}
		
	private void reposicionarObjeto (GameObject obj, int x, int y) {
		obj.transform.position = (Vector3.up * -x * 150) + (Vector3.right * y * 100) + offsetTablero;// + offsetTablero;
	}


	//eliminar paneles restantes

	//elimnar carta del area de juego (x, y)

	//generar paneles / Carta - > paneles en interfaz
		
}
