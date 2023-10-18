using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigo : MonoBehaviour
{
    [SerializeField] PlayerHealth pHealth;
    int Damage;
    // Start is called before the first frame update
    void Start()
    {
        Damage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            pHealth.damagepersonaje(Damage);
        }
    }
}
