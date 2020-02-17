
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public PlayerMovement PlayerMovement;     

	
	void OnCollisionEnter(Collision collisionInfo)
	{
		
		if (collisionInfo.collider.name == "EinStein(Clone)")
		{
			PlayerMovement.enabled = false;  
		}
	}














}