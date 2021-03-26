using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour

{
    [SerializeField]
    private Text starText;
    private int stars=100;
    // Start is called before the first frame update
    void Start()
    {
        UpdateStarText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateStarText()
    {
        starText.text=stars.ToString();
    }
    public void UseStars(int amount)
    {
        if(amount<=stars)
        {
            stars-=amount;
            UpdateStarText();
        }
    }
    public void RewardStars(int amount)
    {
        stars+=amount;
        UpdateStarText();
    }
}
