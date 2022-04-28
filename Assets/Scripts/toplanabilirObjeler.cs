using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanabilirObjeler : MonoBehaviour
{
    [SerializeField] ObjeOzelligi _objeOzelligi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        GameObject obje = collision.gameObject;
        if (obje.GetComponent<PlayerController>()!=null)
        {
            switch (_objeOzelligi)
            {
                case ObjeOzelligi.Canverir:
                    obje.GetComponent<PlayerController>().CaniniYenile(5);
                    break;
                case ObjeOzelligi.HasarVerir:
                    obje.GetComponent<PlayerController>().HasarAl(10);
                    break;
                case ObjeOzelligi.Yavaslatir:
                    break;
                default:
                    break;
            }
        }
      
    }


}
public enum ObjeOzelligi
{
    Canverir,HasarVerir,Yavaslatir

}
