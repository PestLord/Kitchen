using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf[] _shelfs;
    private void Awake()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += CheckShelf;
        }

    }

    private void CheckShelf()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
                shelf.ItemSpawned -= CheckShelf;
            }            
        }

    }
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}