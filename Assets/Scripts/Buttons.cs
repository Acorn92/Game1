using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject ResourcesPanel;
    [SerializeField] private GameObject QuestsPanel;
    //[SerializeField] private

    public void Update()
    {
        if (SettingsPanel.activeSelf || QuestsPanel.activeSelf)
        {
            ResourcesPanel.SetActive(false);
        }
        else
        {
            ResourcesPanel.SetActive(true);
        }

    }

    public void SettingsButtonClick()
    {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
        QuestsPanel.SetActive(false);
    }

    public void QuestsButtonClick()
    {
        QuestsPanel.SetActive(!QuestsPanel.activeSelf);
        SettingsPanel.SetActive(false);


    }
}
