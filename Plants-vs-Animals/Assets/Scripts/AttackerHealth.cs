using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerHealth : MonoBehaviour
{
    [SerializeField]
    private int health;
    [SerializeField]
    private GameObject explosionVFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(){
        health--;
        if(health<0){
            
            InstantiateExplosionVFX();
            Destroy(gameObject);
        }
    }
    void InstantiateExplosionVFX()
    {
        GameObject vfx= Instantiate(explosionVFX,transform.position,transform.rotation);
        Destroy(vfx,1f);
    }

}
