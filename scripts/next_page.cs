using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_page : MonoBehaviour
{
    public GameObject kef1;
    public GameObject kef2;
    public GameObject kef3;
    void Start()
    {
        int k = PlayerPrefs.GetInt("ActiveKef");
        if (k == 1)
        {
            kef1.SetActive(true);
            kef2.SetActive(false);
            kef3.SetActive(false);
        }
        else if (k == 2)
        {
            kef1.SetActive(false);
            kef2.SetActive(true);
            kef3.SetActive(false);
        }
        else
        {
            kef1.SetActive(false);
            kef2.SetActive(false);
            kef3.SetActive(true);
        }
    }
    public void next_kef()
    {
        int k = PlayerPrefs.GetInt("ActiveKef");
        if (k == 1)
        {
            kef1.SetActive(false);
            kef2.SetActive(true);
            kef3.SetActive(false);
            PlayerPrefs.SetInt("ActiveKef", 2);
        }
        else if (k == 2)
        {
            kef1.SetActive(false);
            kef2.SetActive(false);
            kef3.SetActive(true);
            PlayerPrefs.SetInt("ActiveKef", 3);
        }
        else
        {
            kef1.SetActive(true);
            kef2.SetActive(false);
            kef3.SetActive(false);
            PlayerPrefs.SetInt("ActiveKef", 1);
        }

    }
}
