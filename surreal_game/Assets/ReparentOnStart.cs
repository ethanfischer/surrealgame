using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReparentOnStart : MonoBehaviour
{
    void Start()
    {
        if (transform.childCount == 0)
        {
            Rename();
            Reparent();
        }
    }

    private void Rename()
    {
        this.name = transform.parent.name;
        transform.parent.name += "_geometry";
    }

    private void Reparent()
    {
        var initialParent = transform.parent;
        transform.SetParent(transform.parent.parent);
        initialParent.SetParent(this.transform);
    }
}
