using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUObserver : MonoBehaviour
{
    // Start is called before the first frame update
    public override void UpdateScore(int value)
    {
        UpdateScore += value;
        GameManager.instance.UpdateScore(score);
    }
}
