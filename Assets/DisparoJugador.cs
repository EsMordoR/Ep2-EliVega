using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;
    public float shootCooldown;
    private bool canShoot = true;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && canShoot)
        {

            canShoot = false;
            Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
            animator.SetTrigger("Shot");
            //Disparar con click izquierdo con metodo para no disparar seguidamente
            
            Invoke("EnableShooting", shootCooldown);
            
            
            

        }
    }

    private void Disparar()
    {
        
        
     

    }
    void EnableShooting()
    {
        canShoot = true;
        

    }
   
}
