using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadordeMonedas : MonoBehaviour
{
    public static int numeromonedas;
    private Text Contador;
    

    // Start is called before the first frame update
    void Start()
    {
        Contador = GetComponent<Text>(); 
        numeromonedas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Contador.text = "Monedas: " + numeromonedas; 
    }
  
    
}
