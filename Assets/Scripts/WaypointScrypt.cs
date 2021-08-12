using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScrypt : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _nextWaypointStairs;
    private void OnTriggerEnter(Collider other)
    {
        if (MovePlayer.SetRun == true)
            MovePlayer.SetRun = false;
        _player.transform.LookAt(_nextWaypointStairs, Vector3.up);
    }
}
