using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Manager : MonoBehaviour
{
    public int in_score;
    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);

        PlayerPrefs.SetInt("total_score", in_score);
        PlayerPrefs.SetInt("lvl1_score", 0);
        PlayerPrefs.SetInt("lvl2_score", 0);
        PlayerPrefs.SetInt("lvl3_score", 0);
        PlayerPrefs.SetInt("lvl4_score", 0);
        PlayerPrefs.SetInt("questions", 0);
        //level 1
        PlayerPrefs.SetInt("pagida_1", 1);
        PlayerPrefs.SetInt("pagida_2", 1);
        PlayerPrefs.SetInt("pagida_3", 1);
        PlayerPrefs.SetInt("pagida_4", 1);
        
        //level 2
        PlayerPrefs.SetInt("num_1", 1);
        PlayerPrefs.SetInt("num_2", 1);
        PlayerPrefs.SetInt("num_3", 1);
        PlayerPrefs.SetInt("num_4", 1);

        //level 3
        PlayerPrefs.SetInt("bag_1", 1);
        PlayerPrefs.SetInt("bag_2", 1);
        PlayerPrefs.SetInt("bag_3", 1);
        PlayerPrefs.SetInt("bag_4", 1);

        //level 4
        PlayerPrefs.SetInt("bag_5", 1);
        PlayerPrefs.SetInt("bag_6", 1);
        PlayerPrefs.SetInt("bag_7", 1);
        PlayerPrefs.SetInt("bag_8", 1);
        PlayerPrefs.SetInt("bag_9", 1);
        PlayerPrefs.SetInt("bag_10", 1);
    }
}
