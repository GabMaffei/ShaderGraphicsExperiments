using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogoScript : MonoBehaviour
{

    private Renderer rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = gameObject.GetComponent<Renderer>();
        rd.material.SetFloat("_alphaC", 0.019f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position);
        transform.Rotate(90, 0, 0);
    }
}
