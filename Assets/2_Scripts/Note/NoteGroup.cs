using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    [SerializeField] private KeyCode keyCode;
    public KeyCode KeyCode
    {
        get { 
            return keyCode;
        }
    }

    private List<Note> noteList = new List<Note>();

    void Start()
    {
        for(int i = 0; i < noteMaxNum; i++)
        {
            SpawnNote(true);
        }
    }

    private void SpawnNote(bool isApple)
    {
        GameObject noteGameObj = Instantiate(notePrefab);
        noteGameObj.transform.SetParent(noteSpawn.transform);
        noteGameObj.transform.localPosition = Vector3.up * noteList.Count * noteGap;
        Note note = noteGameObj.GetComponent<Note>();
        note.SetSprite(isApple);

        noteList.Add(note);
    }

    public void OnInput(bool isApple)
    {
        //노트 삭제
        if (noteList.Count > 0)
        {
            Note delNote = noteList[0];
            delNote.Destroy();
            noteList.RemoveAt(0);
        }

        //정렬
        for (int i = 0; i < noteList.Count; i++)
            noteList[i].transform.localPosition = Vector3.up * i * noteGap;

        //생성
        SpawnNote(isApple);

        //노트 애니메이션
        anim.Play();
        btnSpriteRender.sprite = SelectBtnSprite;
    }

    public void callAniDone()
    {
        btnSpriteRender.sprite = normalBtnSprite;
    }
}
