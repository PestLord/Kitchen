using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf[] _shelfs;
    private void Awake()
    {
        _shelfs = FindObjectsOfType<Shelf>();
        var _shelf = _shelfs[0];
        var _shelf1 = _shelfs[1];
        
        _shelf.ItemSpawned += CheckShelf;
        _shelf1.ItemSpawned += CheckShelf;
    }

    private void CheckShelf()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }            
        }

    }
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}