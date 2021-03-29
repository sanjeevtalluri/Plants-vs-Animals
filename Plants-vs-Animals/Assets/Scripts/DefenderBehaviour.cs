using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject gun;
    [SerializeField]
    private GameObject missile;
    private EnemySpawnManager[] enemySpawnManagers;
    private EnemySpawnManager myLaneEnemySpawnManager;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        enemySpawnManagers=FindObjectsOfType<EnemySpawnManager>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          if(HasEnemiesInSameLane())
          {
              animator.SetBool("IsAttacking",true);
          }
          else{
              animator.SetBool("IsAttacking",false);
          }
    }
    public void shoot()
    {
        if(HasEnemiesInSameLane())
        {
        Instantiate(missile,gun.transform.position,Quaternion.identity);
        }
        
    }
    private bool HasEnemiesInSameLane()
    {
        SetMyLaneEnemySpawnManager();
        return myLaneEnemySpawnManager.transform.childCount>0;
    }
    private void SetMyLaneEnemySpawnManager()
    {
          foreach(var enemySpawnManager in enemySpawnManagers)
        {
            if(enemySpawnManager.transform.position.y==transform.position.y)
            {
                myLaneEnemySpawnManager=enemySpawnManager;
                break;
            }
        }
    }

}
