using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class initialize_name : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI p_name;
    void Start()
    {
        p_name.text = PlayerPrefs.GetString("Name");
        if (p_name.text.ToLower().EndsWith("ης") || (p_name.text.ToLower().EndsWith("τος")) || (p_name.text.ToLower().EndsWith("ας")) || (p_name.text.ToLower().EndsWith("τοσ")))
        {
            p_name.text = p_name.text.Remove(p_name.text.Length - 1);
        }
        else if (p_name.text.ToLower().EndsWith("ος"))
        {
            p_name.text = p_name.text.Remove(p_name.text.Length - 2);
            if (char.IsUpper(p_name.text, p_name.text.Length))
            {
                p_name.text += "Ε";
            }
            else
            {
                p_name.text += "ε";
            }
            
        }
        p_name.text += "!";
    }
}
