using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroup : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 5;
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private GameObject noteSpawn;
    [SerializeField] private float noteGap = 6f;

    [SerializeField] private SpriteRenderer btnSpriteRender;
    [SerializeField] private Sprite normalBtnSprite;
    [SerializeField] private Sprite SelectBtnSprite;
    [SerializeField] private Animation anim;

    private List<Note> noteList = new List<Note>();

    void Start()
    {
        for(int i = 0; i < noteMaxNum; i++)
        {
            GameObject noteGameObj = Instantiate(notePrefab);
            noteGameObj.transform.SetParent(noteSpawn.transform);
            noteGameObj.transform.localPosition = Vector3.up * noteList.Count * noteGap;
            Note note = noteGameObj.GetComponent<Note>();

            noteList.Add(note);
        }
    }
    public void OnInput(bool v)
    {
        anim.Play();
        btnSpriteRender.sprite = SelectBtnSprite;
    }

    public void callAniDone()
    {
        btnSpriteRender.sprite = normalBtnSprite;
    }
}
