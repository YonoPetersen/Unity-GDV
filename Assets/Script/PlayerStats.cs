using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int leven = 100;
    public float snelheid = 5.0f;
    public string spelerNaam = "Player";
    public bool godMode = false;

    void Start()
    {
        Debug.Log("Speler: " + spelerNaam);
        Debug.Log("Leven: " + leven);
        Debug.Log("Snelheid: " + snelheid);
        Debug.Log("God Mode: " + godMode);
    }
}