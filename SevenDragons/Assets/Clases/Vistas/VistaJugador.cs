using UnityEngine;
using System.Collections;

public class VistaJugador : VistaJuego {

	public GameObject cartaEspecial;

	void Start(){
		//obtenerCartasIniciales ();
	}

	public void generarCarta (Carta carta) {


		//int[,] colores = carta.getColores ();
		GameObject go = generarGameObjetcCarta (carta);

		//Asigna el padre
		DropZone dp = transform.GetComponentInChildren <DropZone>();
		go.transform.SetParent (dp.transform);

	}

//	public void generarCartaEspecial (Carta carta) {
//
//		GameObject go = Instantiate (cartaEspecial) as GameObject;
//		//cambia las imagen (color) de la carta
//		modificarAtributosCartaEspecial (go, carta);
//
//		//Cambiar el texto de la carta
//
//		//Asigna el padre
//		DropZone dp = transform.GetComponentInChildren <DropZone>();
//		go.transform.SetParent (dp.transform);
//
//	}

	//eliminar carta mano

	//opción de poner la funcion del boton del mazo aquí 


	/// <summary>
	/// Eliminar
	/// </summary>
	public void obtenerCarta(){
		
		Mazo instancia = Mazo.obtenerInstancia ();

		//mientras existan cartas
		if (instancia.cantidadDeCartas () != 0) {
			//se obtiene una carta del mazo
			Carta temp = Mazo.obtenerInstancia ().obtenerCarta ();
			//manoJugador.agregarCarta (temp);							//pendiente
			generarCarta (temp);
		}
	}

//	private void obtenerCartasIniciales(){
//		for (int i = 0; i < 3; i++) {
//			obtenerCarta ();
//		}
//	}
		
}