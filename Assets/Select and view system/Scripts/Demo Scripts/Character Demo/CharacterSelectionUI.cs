using System;
using UnityEngine;
using UnityEngine.Events;

public class CharacterSelectionUI : MonoBehaviour
{
    [SerializeField] private Transform characterUiParent;
    [SerializeField] private CharacterUI characterUiPrefab;

    public void CreateCharacterUI(Character character, Action onSelected)
    {
        var characterUi = Instantiate(characterUiPrefab, characterUiParent);
        characterUi.NameText.text = $"Name: {character.Name}";
        characterUi.LevelText.text = $"Level: {character.Level}";
        characterUi.SpriteImage.sprite = character.Sprite;
        characterUi.SelectButton.onClick.AddListener(() => onSelected());
    }
}