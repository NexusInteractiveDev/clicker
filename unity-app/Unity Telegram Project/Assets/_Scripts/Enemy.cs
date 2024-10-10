using Nethereum.RPC.Personal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    public int currenthealth;
    public int enemyReward;
    public Image healthBarFill;

    public void Damage()
    {
        currenthealth--;
        healthBarFill.fillAmount = (float)currenthealth / (float)maxHealth;

        if (currenthealth < 0 )
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        GameManager.instance.AddReward(enemyReward);
        EnemyManager.instance.ReplaceEnemy(gameObject);
    }
}
