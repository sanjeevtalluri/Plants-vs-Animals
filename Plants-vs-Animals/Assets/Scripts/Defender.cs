using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defender : MonoBehaviour
{
    private StarManager starManager;
    // Start is called before the first frame update
    void Start()
    {
       starManager=FindObjectOfType<StarManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddStars(int amount)
    {
        starManager.RewardStars(amount);
    }
}
