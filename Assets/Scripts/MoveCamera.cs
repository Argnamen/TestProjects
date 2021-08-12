using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    void Update()
    {
        Vector3 target = new Vector3(
            _player.transform.position.x, 
            _player.transform.position.y + 0.8f, 
            _player.transform.position.z - 1);
        Vector3 pos = Vector3.Lerp(this.transform.position, target, _speed * Time.deltaTime);

        this.transform.position = pos;
    }
}
