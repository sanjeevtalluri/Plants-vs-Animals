using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject gun;
    [SerializeField]
    private GameObject missile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot(){
        Instantiate(missile,gun.transform.position,Quaternion.identity);
    }
}
