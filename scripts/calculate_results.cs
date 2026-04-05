using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class calculate_results : MonoBehaviour
{
    public TextMeshProUGUI p_name;
    public TextMeshProUGUI t_score;
    public TextMeshProUGUI ar_score;
    public TextMeshProUGUI geo_score;
    public TextMeshProUGUI pr_score;
    public TextMeshProUGUI ep_score;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    void Start()
    {
        p_name.text = PlayerPrefs.GetString("Name");
        t_score.text = PlayerPrefs.GetInt("total_score").ToString();
        ar_score.text = PlayerPrefs.GetInt("lvl1_score").ToString();
        geo_score.text = PlayerPrefs.GetInt("lvl2_score").ToString();
        pr_score.text = PlayerPrefs.GetInt("lvl3_score").ToString();
        ep_score.text = PlayerPrefs.GetInt("lvl4_score").ToString();
        if (PlayerPrefs.GetInt("total_score") >= 17)
        {
            b1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("total_score") >= 15)
        {
            b2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("total_score") >= 11)
        {
            b3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("total_score") >= 7)
        {
            b4.SetActive(true);
        }
        else
        {
            b5.SetActive(true);
        }
    }
}
