using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private Waffle _waffle;
    [SerializeField] private Transform _waffleRoot;
    [SerializeField] private Toaster _toaster;

    private void Start()
    {
        _toaster.TimerIsUp += CreateToast;
    }

    private void CreateToast()
    {
        Instantiate(_waffle, _waffleRoot);
    }
    
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}