using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Outfitter : MonoBehaviour
{
    private List<SpriteResolver> resolver;
    private CharacterType charType;
    
    private enum CharacterType
    {
        Ork,
        Bandit
    }

    private void Awake()
    {
        resolver = GetComponentsInChildren<SpriteResolver>().ToList();
    }

    private void Start()
    {
        ChangeOutfit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            charType = charType == CharacterType.Ork ? CharacterType.Bandit : CharacterType.Ork;
            ChangeOutfit();
        }
    }

    private void ChangeOutfit()
    {
        foreach (var resolver in resolver)
        {
            resolver.SetCategoryAndLabel(resolver.GetCategory(), charType.ToString());
        }
    }
}
