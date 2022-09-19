using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnDiscard : MonoBehaviour
{
    // OnDiscard
    public int discardedCardCount = 0;
    public RawImage upperImage;
    public RawImage downImage;

    public static OnDiscard instance;

    private void Awake()
    {
        instance = this;
    }
}
