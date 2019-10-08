using UnityEngine;
using UnityEngine.UI;

public class showobject : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        return;
        
    }
    void OnMouseDown()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, new Vector3(-2, 9, -17), Quaternion.Euler(0, 90, 0));

    }
}