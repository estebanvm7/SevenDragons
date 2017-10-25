using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : Validacion {

	//instancia estatica
	public static Juego instanciaJuego = new Juego ();

	private Carta[,] areaDeJuego;

	/// <summary>
	/// Initializes a new instance of the <see cref="Juego"/> class.
	/// </summary>

	private Juego () {
		areaDeJuego = new Carta[103, 103];

		//agrega la cara tinicial al juego en la posición 51,51
		int[,] cartaInicial = { { 7, 7 }, { 7, 7 } };
		areaDeJuego [51, 51] = new Carta (cartaInicial);

	}

	public static Juego obtenerInstanciaJuego () {
		return instanciaJuego;
	}

	//la verifica
	public void agregarCartaAlAreaDeJuego (Carta carta, int x, int y) {
		if (verificarMovimiento (carta, x, y)) {
			areaDeJuego [x, y] = carta;
		} else {
			Debug.Log ("Moviemiento invalido");
		}
	}

	public Carta quitarCartaDelAreaDeJuego (int x, int y) {
		//Obtiene la carta del areaDeJuego en la posicion x y y la guarda en un temporal
		Carta temp = areaDeJuego [x, y];
		//elimina la carta del tablero
		areaDeJuego [x, y] = null;

		return temp;
	}

	public Carta obtenerCartaDelAreaDeJuego (int x, int y) {
		return areaDeJuego [x, y];
	}


}
