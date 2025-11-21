using UnityEngine;
using static Unity.AppUI.UI.ExVisualElement;

public class RandomItem : MonoBehaviour
{
    [SerializeField] private string[] bosses = new string[10];

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)) PrintRandomItem();
        if (Input.GetKeyDown(KeyCode.Escape)) PrintAllItems();
    }
    private void PrintRandomItem()
    {
        int RandomItem = Random.Range(0, bosses.Length);
        Debug.Log(bosses[RandomItem]);

    }
    private void PrintAllItems()
    {
        for (int i = 0; i < bosses.Length; i++)
        {
            Debug.Log($"[{i}] {bosses[i]}");
        }

    }
}