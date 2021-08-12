using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _gun;
    void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                _gun.transform.LookAt(ray.direction);

                if (Physics.Raycast(ray))
                {
                    ObjectPool.Instantiate(_gun.transform.position, _gun.transform.rotation, true);
                }
            }
        }
    }
}
