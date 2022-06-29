using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageSet : MonoBehaviour
{
    public TMP_Text LanguageText;
    private int _langSelect;
    int GetLanguage ()
    {
        switch(LanguageText.text)
        {
            case "Русский":
                return 0;
            case "English":
                return 1;
            default: 
                return 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _langSelect = GetLanguage();
    }

    void ChangeLanguage()
    {
        //TODO:
        //открываем файл с переводом
        //переназначаем текстовые поля
    }
}
