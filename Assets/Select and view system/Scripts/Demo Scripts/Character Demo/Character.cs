using UnityEngine;

public class Character : BaseSelectableObject
{
    public int Id { get; private set; }
    public int Level { get; private set; }

    public Character(int id, string name, int level, Sprite sprite, GameObject prefab)
    {
        Id = id;
        Name = name;
        Level = level;
        Sprite = sprite;
        Prefab = prefab;
    }
}
