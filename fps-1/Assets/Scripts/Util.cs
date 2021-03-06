﻿using UnityEngine;
using UnityEngine.Events;
using System;

public static class Util {

    public static void SetLayersRecursively(GameObject obj, int layer)
    {
        if (obj == null)
        {
            return;
        }

        obj.layer = layer;

        foreach (Transform child in obj.transform)
        {
            if (child == null)
            {
                continue;
            }

            SetLayersRecursively(child.gameObject, layer);
        }
    }
}

[Serializable] public class FloatEditorEvent : UnityEvent <float, FloatEditor> {}