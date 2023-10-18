using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    float VelocidadMovimiento;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        VelocidadMovimiento = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Estamirandoderecha())
        {
            rb.velocity = new Vector2(VelocidadMovimiento, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-VelocidadMovimiento, 0f);
        }
    }

    bool Estamirandoderecha()
    {
        return transform.localScale.x > 0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("layerSuelo")) 
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        if (collision.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}

