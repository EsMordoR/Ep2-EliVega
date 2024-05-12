using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigi;
    
    public GameObject muro;
    public float velocidadMovimiento;

    private Vector2 direccion;
    
    // Start is called before the first frame update

    void Start()
    {
        
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

    }

    private void FixedUpdate()
    {
        rigi.MovePosition(rigi.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
    
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Monedas"))
        {
            ContadordeMonedas.numeromonedas  += 1;
            Destroy(collision.gameObject);
            if(ContadordeMonedas.numeromonedas == 6) 
            {
                muro.SetActive(false);
            }
        }
    }
}
