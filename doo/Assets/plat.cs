using UnityEngine;


public class plat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float jumpF=10f;
    void OnCollisionEnter2D(Collision2D colli){
        if(colli.relativeVelocity.y<=0){
            Rigidbody2D rb=colli.collider.GetComponent<Rigidbody2D>();
        if(rb!=null){
            Vector2 veloci= rb.linearVelocity;
            veloci.y=jumpF;
            rb.linearVelocity=veloci;
        }
        }
       
        
    }
    
}

