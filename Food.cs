using UnityEngine;

public class Food : MonoBehaviour
{
    //начальная скорость полета еды
    public float _speed = 50;
    void Start()
    {
        //уничтожаем еду через 10 секунд после создания (чтобы она не засоряла сцену)
        //Destroy(gameObject, ???);
        //Задаем начальную скорость полета еды
        GetComponent<Rigidbody>().velocity = transform.forward * _speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Пробуем взять компонент Animal у объекта, с которым столкнулась еда
        //Animal animal = collision.gameObject.GetComponent<???>();

        //Если у объекта есть компонент Animal, то вызываем у него метод EatFood и уничтожаем еду
        //if (animal != ???)
        //{
        //    animal.???;
        //    Destroy(???);
        //}
    }
}