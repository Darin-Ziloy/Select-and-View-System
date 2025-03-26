using UnityEngine;
using UnityEngine.SceneManagement;

public class Location : BaseSelectableObject
{
    public string Description { get; private set; }
    public string SceneId { get; private set; }

    public Location(string name, string description, Sprite sprite, string sceneId)
    {
        Name = name;
        Description = description;
        Sprite = sprite;
        SceneId = sceneId;
    }

    public void LoadLocation()
    {
        SceneManager.LoadSceneAsync(SceneId);
    }
}