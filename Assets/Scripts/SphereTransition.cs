using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTransition : MonoBehaviour
{
    [SerializeField] private GameObject @object;
    private Transform parent;
    private void Start()
    {
        parent = gameObject.transform.parent;
    }
    public void Transit()
    {
        Instantiate(@object,Vector3.zero, Quaternion.identity);
        Destroy(parent.parent.gameObject);
    }
}
