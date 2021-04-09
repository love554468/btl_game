using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_People : MonoBehaviour
{
    public Rigidbody2D rbb;
	public float jumpforce = 10f;
    public KeyCode right;
	public enum State
	{
		normal,
		jumping
	}
	public State s;
    void Update()
    {
        if (Input.GetKey(right) && s == State.normal)
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
		// if(col.gameObject.tag=="Block" || col.gameObject.tag=="Danger")
		// {
        // //    FindObjectOfType<AudioManager> ().Play ("Gameover");
		// // 	FindObjectOfType<GameManager> ().EndGame();
		// }
	}
}
