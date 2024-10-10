using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AutoClickManager : MonoBehaviour
{
    public List<float> autoClick = new List<float>();

    public int autoClickPrice;
    public TextMeshProUGUI autoClickAmount;

    // Update is called once per frame
    void Update()
    {
        // Loop through each auto clicker
        for (int i = 0; i < autoClick.Count; i++)
        {
            if (Time.time - autoClick[i] >= 1.0f)
            {
                autoClick[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        
        }
    }

    public void OnBuyAutoClick()
    {
        if(GameManager.instance.reward >= autoClickPrice)
        {
            GameManager.instance.RemoveReward(autoClickPrice);
            autoClick.Add(Time.time);

            autoClickAmount.text = "x " + autoClick.Count.ToString();
        }
    }
}
