﻿using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public class CommonAxe : Axe
    {
        public CommonAxe(int damage, GameObject view = null) : base(damage, view) 
        {
            Debug.Log($"<color=green>Common</color> axe created");
        }
    }
}
