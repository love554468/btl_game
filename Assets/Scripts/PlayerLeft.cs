using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection.Emit;

public class PlayerLeft : MonoBehaviour {
	GameController m_gc;
	public GameObject[] point;
	public Rigidbody2D rbb;
	public float jumpforce = 10f;
    public KeyCode left;
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
        if (Input.GetKey(left) && s == State.normal)
        {
            rbb.velocity = Vector2.left * jumpforce;
            s = State.jumping;
        }
    }
	void OnCollisionEnter2D(Collision2D col)// vùng các đối tượng va chạm với nhau
	{
		if(col.gameObject.tag=="Col") // cái đói tượng tròn đen va chạm với đối tượng có tag là ground
		{
			s = State.normal;
		}
		if(col.gameObject.tag=="Block" || col.gameObject.tag=="Danger")
		{
        // //    FindObjectOfType<AudioManager> ().Play ("Gameover");
		// // 	FindObjectOfType<GameManager> ().EndGame();
			Debug.Log("va cham roi ne block");
			m_gc.SetGameOver(true);
		}
		if(col.gameObject.tag=="Point")
		{
			// Debug.Log("va cham roi ne Point");
			m_gc.IncreaseScore();
		}
	}
}
   