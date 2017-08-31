using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoJugador : MonoBehaviour {

	private LinkedList<Carta> mano;


	public ManoJugador() {

		mano = new LinkedList<Carta>();
	}

	public void agregarCarta (Carta c) {
		mano.AddLast (c);
	}

	public Carta sacarCarta (Carta c) {
		LinkedListNode<Carta> temp = mano.Find (c);
		mano.Remove (c);
		return temp.Value;
	}

}
