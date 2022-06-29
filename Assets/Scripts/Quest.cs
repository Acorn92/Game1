using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Quest
{
    private string _header;
    private string _decription;

    public Quest(string header, string description)
    {
        _header = header;
        _decription = description;
    }

    //TODO
    //добавить возможность добавления текста извне
    public string Header => _header;
    public string Decription => _decription; 
}
