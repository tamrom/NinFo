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
    // bi tane mermi spawn edebilirim gameobject  // raycast g�nderebilir ve yok edebilirim
    // basespawner t�klad�g�nda ayn� hizada sa�a veya sola g�nderebilirim --  //   ray cast in degdi�i yeri yok edebilirim 
    // base spawner'�n i�in  
    // bir tane seriazile
}
