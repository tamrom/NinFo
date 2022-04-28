using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firecontroller : MonoBehaviour
{
    [SerializeField] GameObject _mermiObject;
    void Start()
    {
         
    }

    // Update is called once per frame
    
    private void FixedUpdate()
    {
      if(Input.GetMouseButtonUp(0))
        {
            Instantiate(_mermiObject, this.transform.position, transform.rotation);
        }
    }
    // bi tane mermi spawn edebilirim gameobject  // raycast gönderebilir ve yok edebilirim
    // basespawner týkladýgýnda ayný hizada saða veya sola gönderebilirim --  //   ray cast in degdiði yeri yok edebilirim 
    // base spawner'ýn için  
    // bir tane seriazile
}
