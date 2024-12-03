using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestCube script çalýþýyor!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
