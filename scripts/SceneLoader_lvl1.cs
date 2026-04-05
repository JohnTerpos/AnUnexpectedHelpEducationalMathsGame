using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader_lvl1 : MonoBehaviour
{
    public GameObject pagida1;
    public GameObject pagida2;
    public GameObject pagida3;
    public GameObject pagida4;
    public GameObject next_level;
    public GameObject feed;
    public TextMeshProUGUI score;
    public Animator transition;
    public float transitionTime = 1f;
    int Sc;

    void Start()
    {
        if (PlayerPrefs.GetInt("pagida_1") == 1)
        {
            pagida1.SetActive(true);
        }
        else
        {
            pagida1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pagida_2") == 1)
        {
            pagida2.SetActive(true);
        }
        else
        {
            pagida2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pagida_3") == 1)
        {
            pagida3.SetActive(true);
        }
        else
        {
            pagida3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pagida_4") == 1)
        {
            pagida4.SetActive(true);
        }
        else
        {
            pagida4.SetActive(false);
        }

        Sc = PlayerPrefs.GetInt("total_score");
        gameObject.SetActive(true);
        score.text = Sc.ToString();
    }

    void Update()
    {
        if (!pagida1.activeSelf && !pagida2.activeSelf && !pagida3.activeSelf && !pagida4.activeSelf)
        {
            next_level.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lvl1_score")>=3)
        {
            feed.SetActive(true);
        }
    }
    public void SceneLoad()
    {
        StartCoroutine(LoadNextScene(SceneManager.GetActiveScene().buildIndex +1));
    }

    public void reset()
    {

        score.text = 0.ToString();//(int.Parse(score1.text) + 1).ToString();
    }

    public void pagida_1_SceneLoad()
    {
        StartCoroutine(LoadNextScene(14));
        PlayerPrefs.SetInt("pagida_1", 0);

    }

    public void pagida_2_SceneLoad()
    {
        StartCoroutine(LoadNextScene(15));
        PlayerPrefs.SetInt("pagida_2", 0);
    }

    public void pagida_3_SceneLoad()
    {
        StartCoroutine(LoadNextScene(16));
        PlayerPrefs.SetInt("pagida_3", 0);
    }

    public void pagida_4_SceneLoad()
    {
        StartCoroutine(LoadNextScene(17));
        PlayerPrefs.SetInt("pagida_4", 0);
    }

    public void advance_level()
    {
        StartCoroutine(LoadNextScene(18));
    }


    IEnumerator LoadNextScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
