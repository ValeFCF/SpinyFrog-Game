using UnityEngine;
using System.Collections;

public class ritcherController : MonoBehaviour {

	public float moveSpeed;
	private Vector3 moveDirection;
	public float turnSpeed;

	// Use this for initialization
	void Start () {
		moveDirection = Vector3.right;
	
	}
	
	// Update is called once per frame
	void Update () {
		// 1 copiar variable a local la posicion
		Vector3 currentPosition = transform.position;
		// 2 dar click
		if( Input.GetButton("Fire1") ) {
			// 3 pasar la posicion del raton
			Vector3 moveToward = Camera.main.ScreenToWorldPoint( Input.mousePosition );
			// 4 mover ha
			moveDirection = moveToward - currentPosition;
			moveDirection.z = 0; 
			moveDirection.Normalize();
		}

		//Vector3 target = moveDirection * moveSpeed + currentPosition;
		//transform.position = Vector3.Lerp( currentPosition, target, Time.deltaTime );
		//http://en.wikipedia.org/wiki/Quaternion
		float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
		transform.rotation = 
			Quaternion.Slerp( transform.rotation, 
			                 Quaternion.Euler( 0, 0, targetAngle ), 
			                 turnSpeed * Time.deltaTime );
	}
}
