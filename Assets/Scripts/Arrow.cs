using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    public KeyCode arrowKey;

    public void SetArrowKeyAndUpdateSprite(Tuple<KeyCode, Sprite> arrow)
    {
        arrowKey = arrow.Item1;
        GetComponent<SpriteRenderer>().sprite = arrow.Item2;
    }
}
