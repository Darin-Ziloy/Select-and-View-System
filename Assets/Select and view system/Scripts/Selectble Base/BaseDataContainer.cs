using System;

public abstract class BaseDataContainer<T> where T : ISelectableObject
{
    protected T currentSelectedObject;
    public event Action<T> OnObjectSelected;
    public event Action<T> OnObjectDeselected;

    public virtual void SetCurrentObject(T obj)
    {
        if (currentSelectedObject != null)
        {
            if(obj.Name == currentSelectedObject.Name) return;

            currentSelectedObject.Deselect();
            OnObjectDeselected?.Invoke(currentSelectedObject);
        }

        currentSelectedObject = obj;
        currentSelectedObject.Select();
        OnObjectSelected?.Invoke(currentSelectedObject);
    }

    public virtual T GetCurrentObject() => currentSelectedObject;
}