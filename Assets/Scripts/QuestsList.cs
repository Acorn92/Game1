using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestsList : MonoBehaviour
{
    [SerializeField] private QuestView _template;
    [SerializeField] private Transform _container;

    private string q1, q2, q3, q4;

    public void Start()
    {

    }


private void Awake()
    {
        
        q1 = "задание1";
        q2 = "задание2";
        q3 = "задание3";
        q4 = "ОПИСАНИЕ";

        Render(new List<Quest>()
        {
            new Quest(q1, q4),
            new Quest(q2, q4),
            new Quest(q3, q4),
            new Quest(q1, q4),
            new Quest(q2, q4),
            new Quest(q3, q4),
            new Quest(q1, q4),
            new Quest(q2, q4),
            new Quest(q3, q4),
        });        
    }

    private void Render(IEnumerable<Quest> quests)
    {
        foreach (var quest in quests)
        {
            var view = Instantiate(_template, _container) as QuestView;
            view.Render(quest);
        }


    }
}
