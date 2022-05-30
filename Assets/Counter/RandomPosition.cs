using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public float xpos;
    // Start is called before the first frame update
    void Start()
    {
        xpos = Random.Range(-2.30f, 2.30f);
        transform.Translate(xpos, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
