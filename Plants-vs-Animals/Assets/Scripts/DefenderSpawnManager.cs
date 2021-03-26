using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnManager : MonoBehaviour
{
    [SerializeField]
    private Defender defender;
    private StarManager starManager;

    private int defenderCost;
    // Start is called before the first frame update
    void Start()
    {
        starManager=FindObjectOfType<StarManager>();   
    }
    public void SetDefender(Defender defender)
    {
        this.defender=defender;
        defenderCost=defender.GetDefenderCost();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
       // Debug.Log("clicked");
       Vector2 clickedWorldPos=GetWorldPosition();
       Vector2 clickedGridPos=GetGridPosition(clickedWorldPos);
       if(canPlaceDefender(defenderCost))
       {
           BuyDefender(defenderCost);
           SpawnDefender(clickedGridPos);
       }
       
    }
    private void SpawnDefender(Vector2 clickedWorldPos)
    {
        Instantiate(defender,clickedWorldPos,Quaternion.identity);
    }
    private Vector2 GetWorldPosition()
    {
        Vector2 clickedScreenPos=new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        return Camera.main.ScreenToWorldPoint(clickedScreenPos);
    }

    private Vector2 GetGridPosition(Vector2 clickedWorldPos){
        float x=Mathf.RoundToInt(clickedWorldPos.x);
        float y=Mathf.RoundToInt(clickedWorldPos.y);
        return new Vector2(x,y);
    }
    private bool canPlaceDefender(int defenderCost)
    {
        return starManager.GetStars()>=defenderCost;
    }

    private void BuyDefender(int defenderCost)
    {
        starManager.UseStars(defenderCost);
    }
}
