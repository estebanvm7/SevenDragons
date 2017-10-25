using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadFile : MonoBehaviour {

	public static string[] readFile (string filePath) {
		string[] lines = System.IO.File.ReadAllLines (filePath);
		return lines;
	}

}