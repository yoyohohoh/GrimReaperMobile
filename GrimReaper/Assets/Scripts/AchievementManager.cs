using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject tick1;
    [SerializeField] public GameObject tick2;
    [SerializeField] public GameObject tick3;
    [SerializeField] public GameObject title2;
    [SerializeField] public GameObject title3;

    void Awake()
    {
        if (!Instance) Instance = this;
    }
    void Start()
    {
        panel.SetActive(false);
        tick1.SetActive(false);
        tick2.SetActive(false);
        tick3.SetActive(false);
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
