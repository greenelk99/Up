using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlattformSkript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
    }
}
