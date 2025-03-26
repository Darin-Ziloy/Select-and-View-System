using UnityEngine;

[CreateAssetMenu(fileName = "NewLocationPreset", menuName = "Game/LocationPreset")]
public class LocationPreset : ScriptableObject
{
    public string SceneId;
    public string Name;
    public string Description;
    public Sprite Sprite;
}