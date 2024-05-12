using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject Rojo;
    public GameObject Verde;
    public GameObject Azul;

   

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InstanciarRojo", 0.5f);
        Invoke("InstanciarVerde", 1);
        Invoke("InstanciarAzul", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstanciarRojo()
    {
        Instantiate(Rojo);
        
        
    }
    void InstanciarVerde()
    {
        Instantiate(Verde);
    }
    void InstanciarAzul()
    {
        Instantiate(Azul);
    }
}

