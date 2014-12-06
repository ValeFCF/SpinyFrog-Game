using UnityEngine;
using System.Collections;

public class movSprite2 : MonoBehaviour {

	private MovimientoSprites movimientoSprites;
	public float moveSpeed;
	public bool selected;
	
	// Use this for initialization
	void Start () {
		movimientoSprites = new MovimientoSprites ();
		selected = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 currentPosition = transform.position;
		
		if (!selected) {
			
			transform.position = movimientoSprites.moverSprite(currentPosition,moveSpeed);
			print (transform.position);
			
		}
	}
}
