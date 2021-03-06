using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject lizardPrefab;

    [SerializeField]
    private int minSpawnTime=1;

    [SerializeField]
    private int maxSpawnTime=5;
    private bool spawn=true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IEnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator IEnemySpawner(){
        while(spawn){
            SpawnEnemy();       
            yield return new WaitForSeconds(Random.Range(minSpawnTime,maxSpawnTime));
        }
    }
    private void SpawnEnemy()
    {
       GameObject obj= Instantiate(lizardPrefab,transform.position,Quaternion.identity) ;
       obj.transform.SetParent(this.transform);
    }
}
