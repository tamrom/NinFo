using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IHasarAlabilir,ICaniniYenileyebilir
{
    [SerializeField] int _karakterCani;
    [SerializeField] float karakterHizi;
    [SerializeField] private float ziplamaKuvveti;
    [SerializeField] Animator _anim;
    [SerializeField] Rigidbody2D _rg;
    [SerializeField] SpriteRenderer _sg;
    [SerializeField] isground _isground; //içine at

    
    public int KarakterCan
    {
        get
        {
            return _karakterCani;
        }
        set
        {
            _karakterCani = value;
        }
    }
    public void HasarAl(int hasar) //enemy collisionuna carptiginda
    {
        KarakterCan -= hasar;
    }

    public void CaniniYenile(int can)
    {
        KarakterCan += can;
        Debug.Log(_karakterCani);
    }


    private void Update()
    {
        Hareket();
        if (Input.GetButton("Jump")&& _isground.Onground)
        {
            Ziplama();
            _anim.SetBool("__jump", false);  // anim.play _ 

        }
    }
    private void Hareket()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0) * karakterHizi * Time.deltaTime;
        _anim.SetFloat("__speed", Mathf.Abs(horizontal)); // sadece bu satýrý kapsýyor Mathf.abs  |mutlak deger|
        if (horizontal<0)
        {
            
            _sg.flipX = true;
        }
        else
        {
            _sg.flipX = false;
        }

    }
    private void Ziplama()
    {
        _rg.AddForce(Vector2.up * ziplamaKuvveti*Time.deltaTime);
        _anim.SetBool("__jump",true);
    }


}
