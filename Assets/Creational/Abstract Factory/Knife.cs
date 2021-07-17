﻿using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.AbstractFactory
{
    public abstract class Knife : Weapon
    {
        public Knife(int damage, GameObject view) : base(damage, view)
        {

        }
    }
}
