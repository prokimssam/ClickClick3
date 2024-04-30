using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Relay : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"myTime " + GameManager.Instance.myTime);
        Debug.Log($"minTime " + GameManager.Instance.minTime);

        Debug.Log($"GameOver : {GameManager.Instance.IsGameOver()}, GameClear : {GameManager.Instance.IsGameClear()}");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Main");
    }
}
