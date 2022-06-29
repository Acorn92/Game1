using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestView : MonoBehaviour
{
    [SerializeField] private Text _questHeader;
    [SerializeField] private Text _questDescription;

    public void Render(Quest quest)
    {
        _questHeader.text = quest.Header;
        _questDescription.text = quest.Decription;
    }
}
