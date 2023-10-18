using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] Transform PointA; //Los puntos en los que el enemigo gira
    [SerializeField] Transform PointB;
    [SerializeField] float VelocidadMovimiento; //Velocidad a la que se mueve el enemigo
    Rigidbody2D rb; //Referencia al rigidbody
    bool Lookingright;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= PointA.position.x)
        {
            Flip();
            
        }

        if (transform.position.x <= PointB.position.x)
        {
            Flip();
        }

    }

    private void Flip()
    {
        if (Lookingright || !Lookingright )
        {
            Lookingright = !Lookingright;
            Vector2 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
            
            VelocidadMovimiento = VelocidadMovimiento * -1f;
        }
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(VelocidadMovimiento, 0f));
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(PointA.position, 0.5f);
        Gizmos.DrawWireSphere(PointB.position, 0.5f);
        Gizmos.DrawLine(PointA.position, PointB.position);
    }
}
