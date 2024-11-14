using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer Renderer;
    Rigidbody rigidbody;
        [SerializeField]float TimeToWait = 15f;

    // Start is called before the first frame update
    void Start()
    {
       Renderer = GetComponent<MeshRenderer>();
       rigidbody = GetComponent<Rigidbody>();

       Renderer.enabled = false;
       rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            Renderer.enabled = true;
            rigidbody.useGravity = true;
        }
      }
}
