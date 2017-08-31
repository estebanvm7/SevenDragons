using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mazo : MonoBehaviour {

	public Stack<Carta> mazoDeCartas = new Stack<Carta> ();


	public void generarCartasMazo(){

		if (mazoDeCartas.Count != 0) {
			//si el mazo tiene cartas, las borra
			mazoDeCartas.Clear ();
		}

		//##### Eiminar #######
		//Carta Multicolor
		int[,] m = new int[,] { { 6, 6 }, { 6, 6 } };
		this.mazoDeCartas.Push (new Carta (m));

		//Carta
		m = new int[,] { { 3, 1 }, { 2, 4 } };
		this.mazoDeCartas.Push (new Carta (m));


		//Leer un archivo con la configuración de las cartas
		//lista con Cartas
		//Mezclar las cartas
		//Meter las cartas a la pila

	}

	private Carta[] mezclarCartas(Carta[] cartas) {
		/* 
		 * recibe una arreglo de cartas 
		 * debuelve un arreglo mezclado
		 */

		return cartas;
		
	}

	private void crearMazo(Carta[] cartas) {
		//agrega las cartas de la lista a la pila
	}

}

