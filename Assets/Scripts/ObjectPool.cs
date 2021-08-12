using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _amount = 0;
    [SerializeField] private float _speed = 1f;
    public static bool _fillPool = true;
    public static bool _incPool = true;
    private static List<GameObject> pool = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        if(_fillPool && _prefab != null && _amount > 0)
        {
            for (int i = 0; i < _amount; i++)
            {
                GameObject inst = Instantiate(_prefab, this.gameObject.transform);
                inst.SetActive(false);
                pool.Add(inst);
            }
        }
    }

    public static GameObject Instantiate(Vector3 position, Quaternion rotation, bool setActive)
    {
        foreach (GameObject item in pool)
        {
            if (!item.activeInHierarchy)
            {
                item.transform.position = position;
                item.transform.rotation = rotation;
                item.SetActive(true);
                return item;
            }
        }

       

        return null;
    }
}
