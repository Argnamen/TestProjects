using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobAction : MonoBehaviour
{
    public static GameObject _heals;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.ToString() == "whizbang")
        {
            other.gameObject.SetActive(false);
            _heals.GetComponent<Image>().fillAmount -= 0.5f;
            if(_heals.GetComponent<Image>().fillAmount < 0.5f)
            {
                this.gameObject.SetActive(false);
                ++MovePlayer.mobCount;
            }
        }
    }
}
