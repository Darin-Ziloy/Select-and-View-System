using UnityEngine;

public class LocationSelection : MonoBehaviour
{
    public LocationSelectionUI LocationUI;
    private LocationDataContainer locationDataContainer;

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