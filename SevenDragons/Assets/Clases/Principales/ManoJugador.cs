using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoJugador {

	private LinkedList<Carta> mano;
	private Carta meta;					//falta implementación
	//private GameObject parent;


	public ManoJugador() {

		mano = new LinkedList<Carta>();
	}

	public void agregarCarta (Carta c) {
		mano.AddLast (c);
	}
		
	//Opción de obtener la carta por los valores de sus colores (sii no hay cartas iguales)
	public Carta sacarCarta (Carta c) {
		LinkedListNode<Carta> temp = mano.Find (c);
		mano.Remove (c);
		return temp.Value;
	}

	public void setCartaMeta(Carta meta){
		this.meta = meta;
	}

	public Carta GetMeta() {
		return meta;
	}

	public LinkedList<Carta> obtenerMano() {
		return mano;
	}

	public void obtenerCarta(){

		Mazo instancia = Mazo.obtenerInstancia ();

		//mientras existan cartas
		if (instancia.cantidadDeCartas () != 0) {
			//se obtiene una carta del mazo
			Carta temp = Mazo.obtenerInstancia ().obtenerCarta ();
			//agrega carta a la lista de cartas de la mano
			mano.AddLast (temp);
			//generarCarta (temp.getColores ());
		}
	}

	private void obtenerCartasIniciales(){
		for (int i = 0; i < 3; i++) {
			obtenerCarta ();
		}
	}

//	public void obtenerCartaDeMazo(){
//		//agregarCarta (Mazo.mazoDelJuego.on);
//	}

//	public void setParent(GameObject go){
//		parent = go;
//	}

}
