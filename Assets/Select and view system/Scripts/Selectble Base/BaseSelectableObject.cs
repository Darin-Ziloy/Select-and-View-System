using UnityEngine;

public abstract class BaseSelectableObject : ISelectableObject
{
    public string Name { get; protected set; }
    public Sprite Sprite { get; protected set; }
    public GameObject Prefab { get; protected set; }

    public virtual void Select()
    {
        #if UNITY_EDITOR || DEVELOPMENT_BUILD || DEBUG
        Debug.Log($"Object {Name} selected");
        #endif
    }

    public virtual void Deselect()
    {
        #if UNITY_EDITOR || DEVELOPMENT_BUILD || DEBUG
        Debug.Log($"Object {Name} deselected");
        #endif
    }
}