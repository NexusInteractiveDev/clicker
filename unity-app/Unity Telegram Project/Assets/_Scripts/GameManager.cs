using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NBitcoin;

public class GameManager : MonoBehaviour
{
    public int reward;
    public TextMeshProUGUI rewardText;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddReward(int amount)
    {
        reward += amount;
        rewardText.text = "$" + reward.ToString();
    }

    public void RemoveReward(int amount)
    {
        reward -= amount;
        rewardText.text = "$" + reward.ToString();

    }
}
