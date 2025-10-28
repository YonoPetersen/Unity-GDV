using UnityEngine;
using UnityEngine.UIElements;

public class SmartPlayer : MonoBehaviour
{
    public int health = 100;
    float snelheid = 14.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); 
        }

        if (Input.GetKeyDown(KeyCode.Space) && health > 0)
        {
            Jump(); 
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UseKey();
        }
    }

    void Jump()
    {
        Vector3 positie = transform.position;
        {
            positie.y = positie.y + snelheid * Time.deltaTime;
        }

    }

    void UseKey()
    {
        Debug.Log("Key used!");
    }
}