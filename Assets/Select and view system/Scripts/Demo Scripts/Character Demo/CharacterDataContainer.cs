using System.Collections.Generic;
using UnityEngine;

public class CharacterDataContainer : BaseDataContainer<Character>
{
    public Character[] characters { get; private set; }

    public void LoadCharacters()
    {
        var characterPresets = Resources.LoadAll<CharacterPreset>("Characters");
        
        characters = new Character[characterPresets.Length];
        
        for (int i = 0; i < characterPresets.Length; i++)
        {
            characters[i] = new Character(
                i, 
                characterPresets[i].Name, 
                characterPresets[i].Level, 
                characterPresets[i].Sprite, 
                characterPresets[i].Prefab);
        }
    }
}