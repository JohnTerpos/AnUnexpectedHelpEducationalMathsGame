using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader_lvl3 : MonoBehaviour
{
    public GameObject bag1;
    public GameObject bag2;
    public GameObject bag3;
    public GameObject bag4;
    public GameObject next_level;
    public GameObject feed;
    public TextMeshProUGUI score;
    public Animator transition;
    public float transitionTime = 1f;
    int Sc;

    void Start()
    {
        if (PlayerPrefs.GetInt("bag_1") == 1)
        {
            bag1.SetActive(true);
        }
        else
        {
            bag1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_2") == 1)
        {
            bag2.SetActive(true);
        }
        else
        {
            bag2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_3") == 1)
        {
            bag3.SetActive(true);
        }
        else
        {
            bag3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("bag_4") == 1)
        {
            bag4.SetActive(true);
        }
        else
        {
            bag4.SetActive(false);
        }

        Sc = PlayerPrefs.GetInt("total_score");
        gameObject.SetActive(true);
        score.text = Sc.ToString();
    }

    void Update()
    {
        if (!bag1.activeSelf && !bag2.activeSelf && !bag3.activeSelf && !bag4.activeSelf)
        {
            next_level.SetActive(true);
        }
        if (PlayerPrefs.GetInt("total_score")/ PlayerPrefs.GetInt("questions")>=0.8)
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

    public void bag_1_SceneLoad()
    {
        StartCoroutine(LoadNextScene(25));
        PlayerPrefs.SetInt("bag_1", 0);

    }

    public void bag_2_SceneLoad()
    {
        StartCoroutine(LoadNextScene(26));
        PlayerPrefs.SetInt("bag_2", 0);
    }

    public void bag_3_SceneLoad()
    {
        StartCoroutine(LoadNextScene(27));
        PlayerPrefs.SetInt("bag_3", 0);
    }

    public void bag_4_SceneLoad()
    {
        StartCoroutine(LoadNextScene(28));
        PlayerPrefs.SetInt("bag_4", 0);
    }

    public void advance_level()
    {
        StartCoroutine(LoadNextScene(29));
    }

    IEnumerator LoadNextScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}

