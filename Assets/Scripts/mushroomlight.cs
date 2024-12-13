using UnityEngine;

public class mushroomlight : MonoBehaviour
{
    [SerializeField] private Light mushroomLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Geef de XR Rig de tag "Player"
        {
            mushroomLight.enabled = true;
            Debug.Log("Licht aan");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mushroomLight.enabled = false;
            Debug.Log("Licht uit");
        }
    }
}