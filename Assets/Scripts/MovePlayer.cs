using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoint;
    [SerializeField] private int[] _mobOfNumbers;
    public static int mobCount = 0;
    private int i = 0;

    public static bool SetRun = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = _waypoint[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (SetRun == false)
        {
            this.GetComponent<Animator>().SetBool("Run", false);
        }
        if (mobCount == _mobOfNumbers[i])
        {
            ++i;
            mobCount = 0;
            this.GetComponent<Animator>().SetBool("Run", true);
            SetRun = true;
        }
    }
}
