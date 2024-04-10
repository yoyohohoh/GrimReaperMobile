using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    public void ShowAchievementPanel()
    {
        if(panel.activeSelf == false)
        {
            panel.SetActive(true);
        }
        else if (panel.activeSelf == true)
        {
            panel.SetActive(false);
        }
    }
}
