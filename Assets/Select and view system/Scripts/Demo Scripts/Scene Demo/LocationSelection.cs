using UnityEngine;

public class LocationSelection : MonoBehaviour
{
    [SerializeField] private string locationSelectionUiPrefabPath = "UI/Location Selection UI";
    private LocationSelectionUI LocationUI;
    private LocationDataContainer locationDataContainer;

    void Awake()
    {
        LocationUI = Instantiate(Resources.Load<LocationSelectionUI>(locationSelectionUiPrefabPath));
    }

    private void Start()
    {
        locationDataContainer = new LocationDataContainer();
        locationDataContainer.LoadLocations();

        foreach (var location in locationDataContainer.locations)
        {
            LocationUI.CreateCharacterUI(location, () => { locationDataContainer.SetCurrentObject(location); });
        }

        locationDataContainer.OnObjectSelected += OnSelectedLocationChanged;
    }

    private void OnSelectedLocationChanged(Location location)
    {
        location.LoadLocation();
    }
}