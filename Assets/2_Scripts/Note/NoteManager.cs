using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public static NoteManager Instance;
    [SerializeField] private NoteGroup[] noteGroupArr;

    private void Awake()
    {
        Instance = this;
    }

    public void OnInput(KeyCode keyCode)
    {
        int randId = Random.Range(0, noteGroupArr.Length);
        bool isApple = randId == 0 ? true : false;

        foreach (NoteGroup noteGroup in noteGroupArr)
        {
            if (keyCode == noteGroup.KeyCode)
            {
                noteGroup.OnInput(isApple);
            }
        }
    }
}
