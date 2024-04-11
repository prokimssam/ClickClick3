using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouroutineTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        int count = 0;

        while (true)
        {
            Debug.Log(count);
            count++;
            yield return new WaitForSeconds(1);
        }
    }
}
