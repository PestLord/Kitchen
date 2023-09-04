using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] lamps;
    private void Awake()
    {
        lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in lamps)
            {
                lamp.Interact();   
            }
        }
    }
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
}