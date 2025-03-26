using System;
using UnityEngine;

public class LocationSelectionUI : MonoBehaviour
{
    [SerializeField] private Transform locationUiParent;
    [SerializeField] private LocationUI locationUiPrefab;

    public void CreateCharacterUI(Location location, Action onButtonClicked)
    {
        var locationUi = Instantiate(locationUiPrefab, locationUiParent);
        locationUi.NameText.text = $"Name: {location.Name}";
        locationUi.DescriptionText.text = $"Description: {location.Description}";
        locationUi.SceneIdText.text = $"SceneId: {location.SceneId}";
        locationUi.SpriteImage.sprite = location.Sprite;
        locationUi.SelectButton.onClick.AddListener(() => onButtonClicked());
    }
}