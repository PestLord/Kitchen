using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private Transform _place;
    [SerializeField] private GameObject _lamp;
    private void Awake()
    {
        Instantiate(_lamp, _place);
    }
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
}