﻿using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public class RareKnife : Knife
    {
        public RareKnife(int damage, GameObject view = null) : base(damage, view)
        {
            Debug.Log($"<color=blue>Rare</color> knife created");
        }
    }
}
