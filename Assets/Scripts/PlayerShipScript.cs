using UnityEngine;
using System.Collections;

public class PlayerShipScript : MonoBehaviour {
	// adicionando veocidade a nave
	// instanciando
	public Vector2 speed = new Vector2(20, 20);

	// salvando o movimento
	private Vector2 movement;
	
	// Update is called once per frame
	void Update () {
		// pegando informação dos eixos
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		// direções
		movement = new Vector2 (speed.x * inputX, speed.y * inputY);
	}

	void FixedUpdate(){
		// movendo o objeto, não entendi ainda direito essa parada
		rigidbody2D.velocity = movement;
	}
}
