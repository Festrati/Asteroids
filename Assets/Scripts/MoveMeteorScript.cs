using UnityEngine;
using System.Collections;

public class MoveMeteorScript : MonoBehaviour {

	//velocidade
	public Vector2 speed;
	//direcao
	public Vector2 direction;

	public GameObject asteroid;

	void Start()
	{
		speed = new Vector2 (1, 1);
		direction = new Vector2(Random.Range(-5.0F, 10.0F), Random.Range(-5.0F, 10.0F));

	}	
	private Vector2 movement;
		
	void Update()
	{
		// 2 - Movement
		movement = new Vector2(	speed.x * direction.x,
								speed.y * direction.y);
		}
		
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}