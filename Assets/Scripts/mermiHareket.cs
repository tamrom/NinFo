using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiHareket : MonoBehaviour
{
    Rigidbody2D rb;
    private void Awake()
    {
    rb = GetComponent<Rigidbody2D>(); 
     
    }
    void Start()
    {
        rb.velocity = Vector2.right * 500f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
