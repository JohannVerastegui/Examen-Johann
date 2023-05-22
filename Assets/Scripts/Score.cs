using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Score : MonoBehaviour
{
    protected indexer score = 0;

    public abstract void UpdateScore(int value);
}
