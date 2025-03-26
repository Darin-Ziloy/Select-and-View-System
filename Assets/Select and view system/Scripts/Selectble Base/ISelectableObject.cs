public interface ISelectableObject
{
    string Name { get; }
    void Select();
    void Deselect();
}