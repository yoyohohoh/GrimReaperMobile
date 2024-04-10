using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject tick1;
    [SerializeField] public GameObject tick2;
    [SerializeField] public GameObject tick3;
    [SerializeField] public GameObject title2;
    [SerializeField] public GameObject title3;
    [SerializeField] public GameObject reward;

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

    private void Update()
    {
        //if tick1 is active
        if (tick1.activeSelf == true && tick2.activeSelf == true && tick3.activeSelf == true)
        {
            reward.GetComponent<Button>().interactable = true;
        }
        else
        {             
            reward.GetComponent<Button>().interactable = false;
        }
        
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
