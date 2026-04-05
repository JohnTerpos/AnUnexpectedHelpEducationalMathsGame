using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Save_name : MonoBehaviour
{
    public void Save()
    {
        if (GameObject.Find("name_field").GetComponent<TMP_InputField>().text=="")
        {
            PlayerPrefs.SetString("Name", "Παίκτης");
        }
        else
        {
            PlayerPrefs.SetString("Name", GameObject.Find("name_field").GetComponent<TMP_InputField>().text);
        }
        

    }
}
