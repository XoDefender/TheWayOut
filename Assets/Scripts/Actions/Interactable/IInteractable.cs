using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IInteractable
{
    void Interact(Unit interactUnit, Action OnInteractionComplete);
}