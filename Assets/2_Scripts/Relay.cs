using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Relay : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"myTime " + GameManager.myTime);
        Debug.Log($"minTime " + GameManager.minTime);

        Debug.Log($"GameOver : {GameManager.Instance.IsGameOver()}, GameClear : {GameManager.Instance.IsGameClear()}");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Main");
    }
}
