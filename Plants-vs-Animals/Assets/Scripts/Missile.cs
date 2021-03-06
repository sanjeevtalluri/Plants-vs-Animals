using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField]
    private float speed=3f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*Time.deltaTime*speed);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Attacker"){
            AttackerHealth attackerHealth=other.GetComponent<AttackerHealth>();
            if(attackerHealth!=null){
                attackerHealth.DealDamage();
                 Destroy(gameObject);
            }          
        }
    }
}
