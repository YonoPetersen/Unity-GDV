using UnityEngine;
using UnityEngine.UIElements;

public class Script : MonoBehaviour
{
    public float speed = 2;

    void Start()
    {
       // gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        var deltaSpeed = Time.deltaTime * 100;
        transform.Rotate(0, 0, deltaSpeed);


    }
}