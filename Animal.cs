using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : MonoBehaviour
{
    public List<Transform> PatrolPoints;

    //задай минимальный и максимальный размер животного
    //public float MaxScale = ???;
    //public float MinScale = ???;

    //задай скорость уменьшения и увеличения размера
    //public float ScaleDecrease = ???;
    //public float ScaleIncrease = ???;

    NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Patrol();
        Starve();
    }

    void Patrol()
    {
        if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _navMeshAgent.SetDestination(PatrolPoints[Random.Range(0, PatrolPoints.Count)].position);
        }
    }

    //Метод постоянного голода. Плавно уменьшает размер животного и уничтожает его, если он становится слишком маленьким
    void Starve()
    {
        //уменьшаем размер животного на ScaleDecrease в секунду
        //transform.localScale -= ScaleDecrease * Time.deltaTime * Vector3.one;
        
        //Если размер животного стал слишком маленьким, то уничтожаем его
        //if (transform.localScale.x < ???)
        //{
        //    Destroy(???);
        //}
    }

    //Метод увеличения размера животного при попадании в него еды
    public void EatFood()
    {
        //Увеличиваем размер животного на ScaleIncrease
        //???

        //Если размер животного стал слишком большим, то делаем размер равным MaxScale
        //if (???)
        //{
        //    transform.localScale = Vector3.one * MaxScale;
        //}
    }
}
