using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TabGroup : MonoBehaviour
{

    public List<TabButton> tabButtons;

    public Sprite TabIdle;
    public Sprite TabActive;
    public Sprite TabHover;
    // Start is called before the first frame update
    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {

            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        button.background.sprite = TabHover;
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        ResetTabs();
        button.background.sprite = TabActive;
    }

    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            button.background.color = Color.white;
        }
    }
}
