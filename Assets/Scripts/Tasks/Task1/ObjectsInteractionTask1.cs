using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    [SerializeField] private Refrigerator _refrigerator; 
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _refrigerator.Interact();
        }
    }
}
