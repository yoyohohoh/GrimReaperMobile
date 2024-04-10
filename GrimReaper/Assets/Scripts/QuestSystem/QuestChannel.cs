using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestChannel : MonoBehaviour, IObserver
{
    public static QuestChannel Instance;
    [SerializeField] private PlayerController _playerController;

    void Awake()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();       
        if (!Instance) Instance = this;
    }

    void OnEnable()
    {
        _playerController.AddObserver(this);
    }
    void OnDisable()
    {
        _playerController.RemoveObserver(this);
    }
    void Start()
    {


    }

    void Update()
    {

    }

    public void OnNotify(QuestState state, Quest quest)
    {
        switch (state)
        {
            case QuestState.Pending:
                Debug.Log("Quest is pending");
                break;
            case QuestState.Active:
                Debug.Log("Quest is started");
                break;
            case QuestState.Completed:               
                quest.state = QuestState.Completed;
                ChangeToCompleted(quest);
                Debug.Log(quest.name + " is " + quest.state);
                break;

            default:
                break;
        }

    }

    public void ChangeToCompleted(Quest quest)
    {
        if(quest.id == 2)
        {
            AchievementManager.Instance.tick2.SetActive(true);
        }
        if(quest.id == 3)
        {
            AchievementManager.Instance.tick3.SetActive(true);
        }
    }





}
