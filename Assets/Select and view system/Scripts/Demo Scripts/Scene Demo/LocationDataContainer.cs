
using UnityEngine;

public class LocationDataContainer : BaseDataContainer<Location>
{
    public Location[] locations { get; private set; }

    public void LoadLocations()
    {
        var locationPresets = Resources.LoadAll<LocationPreset>("Locations");
        
        locations = new Location[locationPresets.Length];
        
        for (int i = 0; i < locationPresets.Length; i++)
        {
            locations[i] = new Location(
                locationPresets[i].Name, 
                locationPresets[i].Description, 
                locationPresets[i].Sprite, 
                locationPresets[i].SceneId);
        }
    }
}