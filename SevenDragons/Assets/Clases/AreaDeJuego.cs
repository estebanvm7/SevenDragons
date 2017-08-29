using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AreaDeJuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	
		//		for (int x = 0; x < 103; x++) {
		//			for (int y = 0; y < 103; y++) {
		//				if (x == 51 && y == 51) {
		//					//No crear la carta del centro
		//				} else {
		//					generarCarta (x, y);
		//				}
		//			}
		//		}
	
//			Mazo mazo = new Mazo ();
//			int[,] m = new int[2,2];
		//		for (int i = 0; i < 2; i++) {
		//			for (int j = 0; j < 2; j++) {
		//				m[i,j] = 1;
		//			}
		//		}
//			Carta c = new Carta (m);
//			mazo.mazoDeCartas.Push (c);
//	
//			Carta temp = mazo.mazoDeCartas.Peek();
//			bool prueba = temp.esInvertida();
//			Debug.Log (prueba);
		// generarCarta(0,0);
		// generarCarta(0,1);
		//
		//generarCarta (51, 50);
		generarPanel (51, 50);
//		generarCarta (51, 51);
		//generarCarta (51, 52);
		generarPanel (51, 52);
		//generarCarta (50, 51);
		generarPanel (50, 51);
		//generarCarta (52, 51);
		generarPanel (52, 51);
		//
		//
		// generarCarta(50,51);
		// //generarCarta(49,51);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//####################################################
	
	//private Vector3 offsetCarta = new Vector3(2.0f, 0.00f, 2.0f);
	private Carta[,] areaDeJuego = new Carta[103, 103];
	private Vector3 offsetTablero = new Vector3 (-5100.0f, -7575.0f, 0.0f);
	public GameObject carta;
	public GameObject panel;
	
	//#######Funciones#######
	private void generarCarta (int x, int y) {
			
		GameObject go = Instantiate (carta) as GameObject;
		go.transform.SetParent (transform.transform);
		Carta c = go.GetComponent<Carta> ();
		areaDeJuego [x, y] = c;
		reposicionarObjeto (c, x, y);
	}

	private void generarPanel (int x, int y) {

		GameObject go = Instantiate (panel) as GameObject;
		go.transform.SetParent (transform.transform);
		Panel p = go.GetComponent<Panel> ();
		reposicionarObjeto (p, x, y);
	}

	private void reposicionarObjeto (Carta obj, int x, int y) {
		obj.transform.position = (Vector3.right * x * 100) + (Vector3.up * y * 150) + offsetTablero;// + offsetTablero;
	}

	private void reposicionarObjeto (Panel obj, int x, int y) {
		obj.transform.position = (Vector3.right * x * 100) + (Vector3.up * y * 150) + offsetTablero;// + offsetTablero;
	}
	

	//##################	Metodos de la clase
	public void moverCarta () {
	
	}

	public void agregarCarta () {
			
	}
	
	
}
