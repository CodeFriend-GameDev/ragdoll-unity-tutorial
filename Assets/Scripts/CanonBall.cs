using UnityEngine;

// Ce script se trouve sur les projectiles tir�s par le canon
public class CanonBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //On v�rifie si on a touch� le joueur, auquel cas on active son ragdoll
        if(collision.transform.CompareTag("Player"))
        {
            GameObject.Find("Character").GetComponent<CharacterController>().EnableRagdoll();
        }
    }
}
