using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class check_ans : MonoBehaviour
{
    public GameObject inp;
    public GameObject button;
    public GameObject home_button;
    public GameObject correct;
    public GameObject fals;
    //private GameObject game_manager;

    public void check_er1()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "787")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl1_score", PlayerPrefs.GetInt("lvl1_score") + 1);
            correct.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
    }

    public void check_er2()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "11990" || inp.GetComponent<TMP_InputField>().text == "11.990")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl1_score", PlayerPrefs.GetInt("lvl1_score") + 1);
            correct.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
    }

    public void check_er3()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "γ" || inp.GetComponent<TMP_InputField>().text == "Γ" || inp.GetComponent<TMP_InputField>().text == "Γ)" || inp.GetComponent<TMP_InputField>().text == "γ)")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl1_score", PlayerPrefs.GetInt("lvl1_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        GameObject.Find("InputField (TMP)_er3").SetActive(false);
        GameObject.Find("choices").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er4()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text.ToLower() == "σωστό" || inp.GetComponent<TMP_InputField>().text.ToLower() == "σωστo")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl1_score", PlayerPrefs.GetInt("lvl1_score") + 1);
            correct.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
            button.SetActive(false);
            home_button.SetActive(true);
        }
    }

    public void check_er5()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "23" || inp.GetComponent<TMP_InputField>().text == "23 εκ.")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl2_score", PlayerPrefs.GetInt("lvl2_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        GameObject.Find("InputField (TMP)_er5").SetActive(false);
        GameObject.Find("sxima").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }


    public void check_er6()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text =="τμήμα"&& GameObject.Find("InputField_er6_2").GetComponent<TMP_InputField>().text=="κάθετο" && GameObject.Find("InputField_er6_3").GetComponent<TMP_InputField>().text == "απόσταση")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl2_score", PlayerPrefs.GetInt("lvl2_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        GameObject.Find("InputField_er6_1").SetActive(false);
        GameObject.Find("InputField_er6_2").SetActive(false);
        GameObject.Find("InputField_er6_3").SetActive(false);
        GameObject.Find("1 (1)").SetActive(false);
        GameObject.Find("2 (1)").SetActive(false);
        GameObject.Find("3 (1)").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er7()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "15" || inp.GetComponent<TMP_InputField>().text == "15 εκ.")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl2_score", PlayerPrefs.GetInt("lvl2_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er8()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "β" || inp.GetComponent<TMP_InputField>().text == "Β" || inp.GetComponent<TMP_InputField>().text == "β)" || inp.GetComponent<TMP_InputField>().text == "Β)")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl2_score", PlayerPrefs.GetInt("lvl2_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        inp.SetActive(false);
        GameObject.Find("a").SetActive(false);
        GameObject.Find("b").SetActive(false);
        GameObject.Find("c").SetActive(false);
        GameObject.Find("d").SetActive(false);
        GameObject.Find("Image_er8").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er9()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "4,2" || inp.GetComponent<TMP_InputField>().text == "4,2 €" || inp.GetComponent<TMP_InputField>().text == "4 ευρώ και 20 λεπτά" || inp.GetComponent<TMP_InputField>().text == "4 ευρώ, 20 λεπτά")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl3_score", PlayerPrefs.GetInt("lvl3_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er10()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "1,671" || inp.GetComponent<TMP_InputField>().text == "1,671 χμ." || inp.GetComponent<TMP_InputField>().text == "1 χιλιόμετρο και 671 μέτρα" || inp.GetComponent<TMP_InputField>().text == "4 ευρώ, 20 λεπτά")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl3_score", PlayerPrefs.GetInt("lvl3_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er11()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "28" || inp.GetComponent<TMP_InputField>().text == "28 στεφάνια")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl3_score", PlayerPrefs.GetInt("lvl3_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er12()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "α" || inp.GetComponent<TMP_InputField>().text == "Α" || inp.GetComponent<TMP_InputField>().text == "Α)" || inp.GetComponent<TMP_InputField>().text == "α)")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl3_score", PlayerPrefs.GetInt("lvl3_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        GameObject.Find("InputField (TMP)_er12").SetActive(false);
        GameObject.Find("choices_er12").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er13()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text.ToLower() == "λάθος" || inp.GetComponent<TMP_InputField>().text.ToLower() == "λαθος")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er14()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if ((inp.GetComponent<TMP_InputField>().text == "10402"|| inp.GetComponent<TMP_InputField>().text == "10.402") && (GameObject.Find("InputField_er14_2").GetComponent<TMP_InputField>().text == "7010" || GameObject.Find("InputField_er14_2").GetComponent<TMP_InputField>().text == "7.010" )&& (GameObject.Find("InputField_er14_3").GetComponent<TMP_InputField>().text == "11372"|| GameObject.Find("InputField_er14_3").GetComponent<TMP_InputField>().text == "11.372"))
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        GameObject.Find("InputField_er14_1").SetActive(false);
        GameObject.Find("InputField_er14_2").SetActive(false);
        GameObject.Find("InputField_er14_3").SetActive(false);
        GameObject.Find("praxeis").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er15()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text.ToLower() == "λάθος" || inp.GetComponent<TMP_InputField>().text.ToLower() == "λαθος")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        inp.SetActive(false);
        GameObject.Find("Image_er15").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er16()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "4")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        inp.SetActive(false);
        GameObject.Find("Image_er16").SetActive(false);
        GameObject.Find("choices_er16").SetActive(false);
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er17()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if ((inp.GetComponent<TMP_InputField>().text == "3600"|| inp.GetComponent<TMP_InputField>().text == "3.600") && (GameObject.Find("InputField_er17_2").GetComponent<TMP_InputField>().text == "7200"|| GameObject.Find("InputField_er17_2").GetComponent<TMP_InputField>().text == "7.200"))
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }

    public void check_er18()
    {
        PlayerPrefs.SetInt("questions", PlayerPrefs.GetInt("questions") + 1);
        if (inp.GetComponent<TMP_InputField>().text == "9")
        {
            PlayerPrefs.SetInt("total_score", PlayerPrefs.GetInt("total_score") + 1);
            PlayerPrefs.SetInt("lvl4_score", PlayerPrefs.GetInt("lvl4_score") + 1);
            correct.SetActive(true);
        }
        else
        {
            fals.SetActive(true);
        }
        button.SetActive(false);
        home_button.SetActive(true);
    }
}
