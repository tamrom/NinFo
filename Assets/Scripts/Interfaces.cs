using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasarAlabilir 
{

    public int KarakterCan { get; set; }
    void HasarAl(int hasar);

}
public interface ICaniniYenileyebilir
{
    public int KarakterCan { get; set; }
    void CaniniYenile(int can);


}


