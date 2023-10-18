using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float MovimientoHorizontal;

    private float MovimientoVertical;

    private bool Lookingright;

    [SerializeField] int MovementSpeed;

    [SerializeField] int JumpForce;

    [SerializeField] private Transform Groundcheck;

    [SerializeField] LayerMask layerSuelo;
    // Start is called before the first frame update
    private void Awake() //Esto se carga siempre que se inicia el juego
    {
        rb = GetComponent<Rigidbody2D>();
        Lookingright = true;
    }

    void Start() //Esto se carga siempre que se inicia el juego
    {
        rb = GetComponent<Rigidbody2D>();
        Lookingright = true;
    }
    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontal = Input.GetAxisRaw("Horizontal");
        MovimientoVertical = Input.GetAxisRaw("Vertical");
        Flip();
        //OnTheFloor();
        if (MovimientoVertical > 0 && OnTheFloor())
        {
            Debug.Log("Saltando");
            rb.AddForce(new Vector2(0, JumpForce));
        }
    }

    // FixedUpdate se llama si o si 100 veces por segundo
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(MovimientoHorizontal, 0) * MovementSpeed);
    }

    private void Flip()
    {
        if(Lookingright && MovimientoHorizontal < 0f || !Lookingright && MovimientoHorizontal > 0f) 
        {
            Lookingright = !Lookingright;
            Vector2 localscale =transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }
    }

    private bool OnTheFloor()
    {
       return Physics2D.OverlapCircle(Groundcheck.position, 0.2f, layerSuelo);
    }
}
