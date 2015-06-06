using UnityEngine;
using System.Collections;

public class PublicStatic : MonoBehaviour {
	public static int PMovable;
	public static int PPower;
	public static int PDefence;
	// Use this for initialization
	void Awake () {
		PublicStatic.PMovable = 3;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
