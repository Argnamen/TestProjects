using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointStairs : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _nextWaypointStairs;
    private void OnTriggerEnter(Collider other)
    {
        _player.transform.LookAt(_nextWaypointStairs, Vector3.up);
    }
}
