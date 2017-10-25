using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaJuego : MonoBehaviour{

	public GameObject cartaCuadrantes;
	public GameObject cartaCompleta;
	public GameObject cartaDobleHorizontal;
	public GameObject cartaDobleVertical;
	public GameObject cartaTrioArriba;
	public GameObject cartaTrioIzquierda;

	public GameObject vistaJugador;
	public GameObject vistaAreaDeJuego;

	public Texture amarillo;
	public Texture azul;
	public Texture negro;
	public Texture rojo;
	public Texture verde;
	public Texture colores;

	private List<GameObject> listaVistaJugador;

	void Start() {
		generarVistaAreaDeJuego ();
		generarVistaJugador ();
		generarVistaJugador ();
	}

	private Texture obtenerTextura(int color) {

		switch (color) {

		case 1:
			return azul;

		case 2:
			return rojo;

		case 3:
			return amarillo;

		case 4:
			return negro;

		case 5:
			return verde;

		case 6:
			return colores;

		default:
			Debug.Log ("textura con identifocador no valido");
			return null;
		}
	}

	protected void modificarAtributosCarta(GameObject go, int [,] colores){

		UnityEngine.UI.RawImage[] images = go.GetComponentsInChildren<UnityEngine.UI.RawImage> ();

		foreach (var image in images) {
			if (image.tag.Equals ("image00") || image.tag.Equals ("arriba") || image.tag.Equals ("izquierda") || image.tag.Equals ("completa")) {
				image.texture = obtenerTextura (colores [0, 0]);
			} else if (image.tag.Equals ("image01")) {
				image.texture = obtenerTextura (colores [0, 1]);
			} else if (image.tag.Equals ("image10")) {
				image.texture = obtenerTextura (colores [1, 0]);
			} else if (image.tag.Equals ("image11") || image.tag.Equals ("abajo") || image.tag.Equals ("derecha")) {
				image.texture = obtenerTextura (colores [1, 1]);
			} else {
				image.texture = null;
				Debug.Log ("textura de la imagen tiene nombre no reconocido");
			}
		}
	}

	protected void modificarAtributosCartaEspecial (GameObject go, Carta color){

		//UnityEngine.UI.RawImage[] images = go.GetComponentsInChildren<UnityEngine.UI.RawImage> ();

	}

	protected GameObject generarGameObjetcCarta (Carta carta){

		//obtiene los colores de la carta 
		int[,] colores = carta.getColores ();
		GameObject go = null;

		//todos del mismo color
		if (colores [0, 0] == colores [0, 1] && colores [1, 0] == colores [1, 1] && colores [1, 0] == colores [0, 0]) {
			go = Instantiate (cartaCompleta) as GameObject;
		} 
		//filas iguales
		else if (colores [0, 0] == colores [0, 1] && colores [1, 0] == colores [1, 1]) {
			go = Instantiate (cartaDobleHorizontal) as GameObject;
		} 
		//columnas iguales
		else if (colores [0, 0] == colores [1, 0] && colores [0, 1] == colores [1, 1]) {
			go = Instantiate (cartaDobleVertical) as GameObject;
		} 
		//columna izquiera igual, derecha diferentes
		else if (colores [0, 0] == colores [1, 0] && colores [0, 1] != colores [1, 1]) {
			go = Instantiate (cartaTrioIzquierda) as GameObject;
		} 
		//fila arriba igual y fila abajo diferente
		else if (colores [0, 0] == colores [0, 1] && colores [1, 0] != colores [1, 1]) {
			go = Instantiate (cartaTrioArriba) as GameObject;
		} 
		//
		else if (colores [0, 0] != colores [0, 1] && colores [1, 0] != colores [1, 1] && colores [1, 0] != colores [0, 0]) {
			go = Instantiate (cartaCuadrantes) as GameObject;
		} else {
			Debug.LogError ("Valor ivalido");
		}

		//cambia las imagenes (colores) de la carta
		modificarAtributosCarta (go, colores);

		go.GetComponent<Desplazable> ().setCarta (carta);

		return go;
	}
		
	private void generarVistaAreaDeJuego(){
		GameObject go = Instantiate (vistaAreaDeJuego) as GameObject;
		VistaJuego temp = transform.GetComponentInChildren <VistaJuego>();
		go.transform.SetParent (temp.transform);
	}

	private void generarVistaJugador(){
		GameObject go = Instantiate (vistaJugador) as GameObject;
		VistaJuego temp = transform.GetComponentInChildren <VistaJuego>();
		go.transform.SetParent (temp.transform);
	}
		
}


