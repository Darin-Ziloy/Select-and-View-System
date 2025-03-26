using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterPreset", menuName = "Game/CharacterPreset")]
public class CharacterPreset : ScriptableObject
{
    public string Name;
    public int Level;
    public Sprite Sprite;
    public GameObject Prefab;
}