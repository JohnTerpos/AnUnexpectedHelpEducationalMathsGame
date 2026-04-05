using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader_lvl4 : MonoBehaviour
{
    public GameObject bag5;
    public GameObject bag6;
    public GameObject bag7;
    public GameObject bag8;
    public GameObject bag9;
    public GameObject bag10;
    public GameObject next;
    public GameObject feed;
    public TextMeshProUGUI score;
    public Animator transition;
    public float transitionTime = 1f;
    int Sc;

    void Start()
    {
        if (PlayerPrefs.GetInt("bag_5") == 1)
        {
            bag5.SetActive(true);
        }
        else
        {
            bag5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_6") == 1)
        {
            bag6.SetActive(true);
        }
        else
        {
            bag6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_7") == 1)
        {
            bag7.SetActive(true);
        }
        else
        {
            bag7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_8") == 1)
        {
            bag8.SetActive(true);
        }
        else
        {
            bag8.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_9") == 1)
        {
            bag9.SetActive(true);
        }
        else
        {
            bag9.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_10") == 1)
        {
            bag10.SetActive(true);
        }
        else
        {
            bag10.SetActive(false);
        }

        Sc = PlayerPrefs.GetInt("total_score");
        gameObject.SetActive(true);
        score.text = Sc.ToString();
    }

    void Update()
    {
        if (!bag5.activeSelf && !bag6.activeSelf && !bag7.activeSelf && !bag8.activeSelf && !bag9.activeSelf && !bag10.activeSelf)
        {
            next.SetActive(true);
        }
        if (PlayerPrefs.GetInt("total_score") / PlayerPrefs.GetInt("questions") >= 0.8)
        {
            feed.SetActive(true);
        }
        else
        {
            feed.SetActive(false);  
        }
    }
    public void SceneLoad()
    {
        StartCoroutine(LoadNextScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void reset()
    {

        score.text = 0.ToString();//(int.Parse(score1.text) + 1).ToString();
    }

    public void bag_5_SceneLoad()
    {
        StartCoroutine(LoadNextScene(31));
        PlayerPrefs.SetInt("bag_5", 0);

    }

    public void bag_6_SceneLoad()
    {
        StartCoroutine(LoadNextScene(32));
        PlayerPrefs.SetInt("bag_6", 0);
    }

    public void bag_7_SceneLoad()
    {
        StartCoroutine(LoadNextScene(33));
        PlayerPrefs.SetInt("bag_7", 0);
    }

    public void bag_8_SceneLoad()
    {
        StartCoroutine(LoadNextScene(34));
        PlayerPrefs.SetInt("bag_8", 0);
    }

    public void bag_9_SceneLoad()
    {
        StartCoroutine(LoadNextScene(35));
        PlayerPrefs.SetInt("bag_9", 0);
    }

    public void bag_10_SceneLoad()
    {
        StartCoroutine(LoadNextScene(36));
        PlayerPrefs.SetInt("bag_10", 0);
    }

    public void advance()
    {
        StartCoroutine(LoadNextScene(37));
    }

    IEnumerator LoadNextScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}

