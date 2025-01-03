using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class playerM : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
Rigidbody2D rb;
BoxCollider2D boxCol;
public float moveSpeed=10f;
float movement=0f;
public Transform PlatformE;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        boxCol=GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement=Input.GetAxis("Horizontal")*moveSpeed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("yellowPlat"))
        {
            // Check if the player is above the platform
            if (transform.position.y > col.transform.position.y && rb.linearVelocity.y <= 0)
            {
                Destroy(col.gameObject); 
                return;// Destroy the platform
            }
        }
    }
    void FixedUpdate(){
        Vector2 velo=rb.linearVelocity;
        velo.x=movement;
        rb.linearVelocity=velo;
    }
}
