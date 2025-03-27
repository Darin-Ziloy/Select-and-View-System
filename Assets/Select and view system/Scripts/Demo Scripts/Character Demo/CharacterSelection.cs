using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private string characterSelectionUIPrefabPath = "UI/Character Selection UI";
    private CharacterSelectionUI characterSelectionUI;
    private GameObject selectedCharacter;
    private CharacterDataContainer characterDataContainer;
    private IInputHandler crossPlatformInputHandler;
    
    void Awake()
    {
        characterSelectionUI = Instantiate(Resources.Load<CharacterSelectionUI>(characterSelectionUIPrefabPath));
    }

    private void Start()
    {
        crossPlatformInputHandler = new CrossPlatformInputHandler();
        crossPlatformInputHandler.OnInputDirection += OnInputDirection;

        characterDataContainer = new CharacterDataContainer();
        characterDataContainer.LoadCharacters();

        characterDataContainer.OnObjectSelected += OnChracterSelected;
        
        foreach (var character in characterDataContainer.characters)
        {
            characterSelectionUI.CreateCharacterUI(character, () => { characterDataContainer.SetCurrentObject(character); });
        }
    }

    private void Update()
    {
        if (crossPlatformInputHandler != null)
            crossPlatformInputHandler.Update();
    }
    
    private void OnChracterSelected(Character character)
    {
        if(selectedCharacter != null)
            Destroy(selectedCharacter);
        
        selectedCharacter = Instantiate(character.Prefab, Vector3.zero, Quaternion.identity);
    }

    private void OnInputDirection(Vector2 direction)
    {
        if(direction.x > 0)
            SetCharacterByIndex(characterDataContainer.GetCurrentObject().Id + 1);
        else if(direction.x < 0)
            SetCharacterByIndex(characterDataContainer.GetCurrentObject().Id - 1);
    }

    private void SetCharacterByIndex(int index)
    {
        int length = characterDataContainer.characters.Length;
        int newIndex = ((index % length) + length) % length;
        characterDataContainer.SetCurrentObject(characterDataContainer.characters[newIndex]);
    }
}
