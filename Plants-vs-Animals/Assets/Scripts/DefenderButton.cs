using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField]
    private Defender defender;
    private DefenderSpawnManager defenderSpawnManager;
    // Start is called before the first frame update
    void Start()
    {
        defenderSpawnManager=FindObjectOfType<DefenderSpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        TogglingDefenders();
        //setting the defender
        defenderSpawnManager.SetDefender(defender);

    }
    private void TogglingDefenders()
    {
         var buttons=FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons){
            button.GetComponent<SpriteRenderer>().color=new Color32(41,41,41,255);
        }
        gameObject.GetComponent<SpriteRenderer>().color=Color.white;

    }
}
