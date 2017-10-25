using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mazo {

	//instancia estatica
	public static Mazo instanciaMazo = new Mazo ();

	private Stack<Carta> mazoDeCartas;

	//----Funicones---

	public static Mazo obtenerInstancia() {

		return instanciaMazo;
	}

	//constructor privado
	private Mazo(){

		generarCartasMazo ();

	}

	private void generarCartasMazo () {
		
		//verifica si existen cartas un mazo
		if (mazoDeCartas == null) {
			//si no hay lo crea (lazy)
			mazoDeCartas = new Stack<Carta> ();
		} else { 
			//si el mazo tiene cartas, las borra
			mazoDeCartas.Clear ();
		}


		//lista de cartas 
		List<Carta> cartas = new List<Carta>();

		//lee el archivo con los colores de las cartas
		string[] lines = ReadFile.readFile ("/Users/Esteban/Documents/GitHub/SevenDragons/SevenDragons/Assets/cartasINIT.txt");
		foreach (string line in lines) {

			if (line [0] == 'c') {

				int posicion00 = (int)Char.GetNumericValue (line [1]);
				int posicion01 = (int)Char.GetNumericValue (line [2]);
				int posicion10 = (int)Char.GetNumericValue (line [3]);
				int posicion11 = (int)Char.GetNumericValue (line [4]);

				//crea una matriz con los colores
				int[,] colores = new int[,] { { posicion00, posicion01 }, { posicion10, posicion11 } };

				//crea el objeto carta
				Carta temp = new Carta (colores);

				//agrega la carta a la lista
				cartas.Add (temp);
			} 

			else if (line [0] == 'e') {
				
				int tipoEspecial = (int)Char.GetNumericValue (line [1]);

				//crea una matriz con el color especial
				int[,] colorEspecial = new int[,] { { tipoEspecial, tipoEspecial }, { tipoEspecial, tipoEspecial } };

				//crear el objeto carta
				Carta temp = new Carta (colorEspecial);

				//agrega la carta a la lista
				cartas.Add (temp);
				
			} else {
				Debug.Log ("Archivo cartas con identificador invalido");
			}
		}

		//retorna la lista mezclada y la asigna a la variable cartas perviamente creada
		cartas = mezclarCartas (cartas);

		//se crea la pila de cartas
		crearMazo (cartas);

	}

	private void crearMazo (List<Carta> cartas) {
		foreach (var item in cartas) {
			mazoDeCartas.Push (item);
		}
	}

	private List<Carta>  mezclarCartas (List<Carta> cartas) {

		//genera la semila del random
		System.Random rnd = new System.Random ();
		//tamaño de la lista de cartas
		int max = (cartas.Count);

		//intercambia cartas 50 veces
		for (int i = 0; i < 50; i++) {

			//obtiene dos digitos aleatorios 
			int num1 = rnd.Next (0, max);
			int num2 = rnd.Next (0, max);

			//variable temporal para que no se pierda el valor
			Carta temp = cartas [num1];

			//intercambio de valores
			cartas [num1] = cartas [num2];
			cartas [num2] = temp;

		}

		return cartas;

	}

	public Carta obtenerCarta() {
		return mazoDeCartas.Pop ();
	}

	public int cantidadDeCartas(){
		return mazoDeCartas.Count;
	}

}

