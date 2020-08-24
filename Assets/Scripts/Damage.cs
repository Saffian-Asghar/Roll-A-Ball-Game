using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	
	public float damageAmount = 10.0f;
	public bool damageOnTrigger = true; // for the red board below ( death zone )
	public bool damageOnCollision = false; // enemy collision
	public bool destroySelfOnImpact = false;	// self destruct player when enemy hits you
	public float delayBeforeDestroy = 0.0f;
	public GameObject explosionPrefab;

	void OnTriggerEnter(Collider collision)
	{	
		if (damageOnTrigger) { 
			if (collision.gameObject.GetComponent<Health> () != null) {
				collision.gameObject.GetComponent<Health> ().ApplyDamage (damageAmount);
		
				if (destroySelfOnImpact) {
					Destroy (gameObject, delayBeforeDestroy);
				}
			
				if (explosionPrefab != null) {
					Instantiate (explosionPrefab, transform.position, transform.rotation);
				}
			}
		}
	}


	void OnCollisionEnter(Collision collision)
	{	
		if (damageOnCollision) {
			if (collision.gameObject.GetComponent<Health> () != null) {
				collision.gameObject.GetComponent<Health> ().ApplyDamage (damageAmount);
			
				if (destroySelfOnImpact) {
					Destroy (gameObject, delayBeforeDestroy);
				}
			
				if (explosionPrefab != null) {
					Instantiate (explosionPrefab, transform.position, transform.rotation);
				}
			}
		}
	}


	
}