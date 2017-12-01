using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	private Material material;
	void Start () {
		material = GetComponent<Renderer> ().material;
	}

	public void PointerEnterHandler() {
		material.SetColor ("_Color", Color.green);
	}

	public void PointerExitHandler() {
		material.SetColor ("_Color", Color.blue);
	}

	public void PointerClickHandler() {
		material.SetColor ("_Color", Color.red);
	}
}
