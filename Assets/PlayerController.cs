using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public int Movable;
	// Use this for initialization
	void Start () 
	{
		PlayerMove ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	public void PlayerMove ()
	{
		Movable = PublicStatic.PMovable;
	}
	public void TurnEnemy ()
	{
		this.GetComponent<PlayerController> ().enabled = false;
	}
	public void PlayerUp ()
	{
		if (Movable > 0)
		{
			this.transform.position += new Vector3 (0f,0f,1f);
			Movable --;
		}
	}
	public void PlayerDown ()
	{
		if (Movable > 0)
		{
			this.transform.position += new Vector3 (0f,0f,-1f);
			Movable --;
		}
	}
	public void PlayerRight ()
	{
		if (Movable > 0)
			{
			this.transform.position += new Vector3 (1f,0f,0f);
			Movable --;
		}
	}
	public void PlayerLeft ()
	{
		if (Movable > 0)
		{
			this.transform.position += new Vector3 (-1f,0f,0f);
			Movable --;
		}
	}
}
