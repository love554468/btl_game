using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection.Emit;

public class PlayerRight : MonoBehaviour {
	GameController m_gc;
	public GameObject[] c;
	public Rigidbody2D rbb;
	public float jumpforce = 10f;
    public KeyCode right;
	public enum State
	{
		normal,
		jumping
	}
	public State s;
	void Start() {
		m_gc = FindObjectOfType<GameController> ();
	}
    void Update()
    {
        if (Input.GetKey(right) && s == State.normal)
        {
            rbb.velocity = Vector2.right * jumpforce;
            s = State.jumping;
        }
    }
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag=="Col") 
		{
			s = State.normal;
		}
		if(col.gameObject.tag=="Block" || col.gameObject.tag=="Danger")
		{
        // //    FindObjectOfType<AudioManager> ().Play ("Gameover");
		// // 	FindObjectOfType<GameManager> ().EndGame();
			// Debug.Log("va cham roi ne block");
			m_gc.SetGameOver(true);
			return;
		}
		if(col.gameObject.tag=="Point" )
		{
			Debug.Log("va cham roi ne Point");
			m_gc.IncreaseScoreRight();

		}
	}
}
   