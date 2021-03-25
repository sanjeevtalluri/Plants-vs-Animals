using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnManager : MonoBehaviour
{
    [SerializeField]
    private Defender defender;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetDefender(Defender defender)
    {
        this.defender=defender;
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
       SpawnDefender(clickedGridPos);
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
}
