using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Objet", menuName = "Objet", order = 1)]
public class Object : ScriptableObject
{
    public string nom;
    public GameObject model;
    [TextArea(15, 20)] public string description;

}
