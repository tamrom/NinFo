using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isground : MonoBehaviour
{
    [SerializeField] Transform[] _foots;
    [SerializeField] bool onground;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _layerMask;

    public bool Onground { get { return onground; } }

    private void Update()
    {
        foreach (var item in _foots)
        {
            CheckOnground(item);
        }
    }
    void CheckOnground(Transform _transform)
    {

        RaycastHit2D hit = Physics2D.Raycast(_transform.position,Vector2.down,_maxDistance,_layerMask);
        Debug.DrawRay(_transform.position, Vector2.down * _maxDistance,Color.red);
        if (hit.collider!=null)
        {
            onground = true;
        }
        else
        {
            onground = false;
        }

    }

}
