using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        gameObject.SetActive(true);
    }

    public void SceneLoad()
    {
        StartCoroutine(LoadNextScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void return_to_lvl1()
    {
        StartCoroutine(LoadNextScene(13));
    }

    public void return_to_lvl2()
    {
        StartCoroutine(LoadNextScene(18));
    }

    public void return_to_lvl3()
    {
        StartCoroutine(LoadNextScene(24));
    }

    public void return_to_lvl4()
    {
        StartCoroutine(LoadNextScene(30));
    }

    public void return_to_main_menu()
    {
        StartCoroutine(LoadNextScene(0));
    }

    public void go_to_help()
    {
        PlayerPrefs.SetInt("PreviousQuestion", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("ActiveKef", 1);
        StartCoroutine(LoadNextScene(20));
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Load_previous_question()
    {
        StartCoroutine(LoadNextScene(PlayerPrefs.GetInt("PreviousQuestion")));
    }

    IEnumerator LoadNextScene(int sceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
