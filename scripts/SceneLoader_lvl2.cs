using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader_lvl2 : MonoBehaviour
{
    public GameObject num1;
    public GameObject num2;
    public GameObject num3;
    public GameObject num4;
    public GameObject next_level;
    public GameObject feed;
    public TextMeshProUGUI score;
    public Animator transition;
    public float transitionTime = 1f;
    int Sc;

    void Start()
    {
        if (PlayerPrefs.GetInt("num_1") == 1)
        {
            num1.SetActive(true);
        }
        else
        {
            num1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("num_2") == 1)
        {
            num2.SetActive(true);
        }
        else
        {
            num2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("num_3") == 1)
        {
            num3.SetActive(true);
        }
        else
        {
            num3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("num_4") == 1)
        {
            num4.SetActive(true);
        }
        else
        {
            num4.SetActive(false);
        }

        Sc = PlayerPrefs.GetInt("total_score");
        gameObject.SetActive(true);
        score.text = Sc.ToString();
    }

    void Update()
    {
        if (!num1.activeSelf && !num2.activeSelf && !num3.activeSelf && !num4.activeSelf)
        {
            next_level.SetActive(true);
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

    public void num_1_SceneLoad()
    {
        StartCoroutine(LoadNextScene(19));
        PlayerPrefs.SetInt("num_1", 0);

    }

    public void num_2_SceneLoad()
    {
        StartCoroutine(LoadNextScene(21));
        PlayerPrefs.SetInt("num_2", 0);
    }

    public void num_3_SceneLoad()
    {
        StartCoroutine(LoadNextScene(22));
        PlayerPrefs.SetInt("num_3", 0);
    }

    public void num_4_SceneLoad()
    {
        StartCoroutine(LoadNextScene(23));
        PlayerPrefs.SetInt("num_4", 0);
    }

    public void advance_level()
    {
        StartCoroutine(LoadNextScene(24));
    }

    IEnumerator LoadNextScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}

