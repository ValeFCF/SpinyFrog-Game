using UnityEngine;
using System.Collections;

public class MovimientoSprites {

	private Vector2 moveDirection;
	private Vector2 nextPositionSprite, posUnoSprt,posDosSprt,posTresSprt,posCuatroSprt,posCincoSprt;
	//private float moveSpeed;

	public MovimientoSprites(){
		posUnoSprt = new Vector2 (-0.7f, 0.7f);
		posDosSprt = new Vector2 (0.6f,1.0f);
		posTresSprt = new Vector2 (1.0f,-0.2f);
		posCuatroSprt = new Vector2 (0.2f,-1.0f);
		posCincoSprt = new Vector2 (-1.0f,-0.6f);
		//moveSpeed = 0.4f;
	}

	public Vector2 moverSprite(Vector2 currentPosition,float moveSpeed){

		if (currentPosition.x >= (posUnoSprt.x - 0.02) && currentPosition.x <= (posUnoSprt.x + 0.02) &&
		    currentPosition.y >= (posUnoSprt.y - 0.02) && currentPosition.y <= (posUnoSprt.y + 0.02) ) {
			nextPositionSprite = posDosSprt;
			moveDirection = nextPositionSprite - currentPosition; 
			moveDirection.Normalize();
//			print("111");
		}else if(currentPosition.x >= (posDosSprt.x - 0.02) && currentPosition.x <= (posDosSprt.x + 0.02) &&
		         currentPosition.y >= (posDosSprt.y - 0.02) && currentPosition.y <= (posDosSprt.y + 0.02) ){
			nextPositionSprite = posTresSprt;
			moveDirection = nextPositionSprite - currentPosition; 
			moveDirection.Normalize();
//			print("holi222");
		}else if(currentPosition.x >= (posTresSprt.x - 0.02) && currentPosition.x <= (posTresSprt.x + 0.02) &&
		         currentPosition.y >= (posTresSprt.y - 0.02) && currentPosition.y <= (posTresSprt.y + 0.02) ){
			nextPositionSprite = posCuatroSprt;
			moveDirection = nextPositionSprite - currentPosition; 
			moveDirection.Normalize();
		}else if(currentPosition.x >= (posCuatroSprt.x - 0.02) && currentPosition.x <= (posCuatroSprt.x + 0.02) &&
		         currentPosition.y >= (posCuatroSprt.y - 0.02) && currentPosition.y <= (posCuatroSprt.y + 0.02) ){
			nextPositionSprite = posCincoSprt;
			moveDirection = nextPositionSprite - currentPosition; 
			moveDirection.Normalize();
		}else if(currentPosition.x >= (posCincoSprt.x - 0.02) && currentPosition.x <= (posCincoSprt.x + 0.02) &&
		         currentPosition.y >= (posCincoSprt.y - 0.02) && currentPosition.y <= (posCincoSprt.y + 0.02) ){
			nextPositionSprite = posUnoSprt;
			moveDirection = nextPositionSprite - currentPosition; 
			moveDirection.Normalize();
		}

		Vector2 target = moveDirection * moveSpeed + currentPosition;
		//Vector2 Lerp(Vector2 from, Vector2 to, float time);
		return Vector2.Lerp( currentPosition, target, Time.deltaTime );

	}
}
