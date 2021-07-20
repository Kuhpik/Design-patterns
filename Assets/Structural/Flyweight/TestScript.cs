using NaughtyAttributes;
using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class TestScript : MonoBehaviour
    {
        [Header("Info")]
        [SerializeField] [Multiline] [ReadOnly] string _info = "Test while in Play mode.\nUse memory profiler.";

        [Header("Settings")]
        [SerializeField] int _testCount = 100000;
        [SerializeField] int _countPerFrame = 5000;

        [Header("Serialized values")]
        [SerializeField] Sprite[] _possibleSprites;
        [SerializeField] Color[] _possibleColors;
        [SerializeField] string[] _possibleNames;

        FlyweightFactory _flyweightFactory;

        //100K Transforms allocates 58 mb
        //100K MonoBehaviours allocates 42 mb

        [Button]
        void DefaultCreation() 
        {
            //Unity allocates 400 mb
            StartCoroutine(CreationRoutine(CreateDefaultCar));
        }

        [Button]
        void FlyweightCreation()
        {
            //Unity allocates 350 mb.
            //But string hashes generating ~400 mb of garbage.
            //Have to wait some time before GC removes it.
            _flyweightFactory = new FlyweightFactory();
            StartCoroutine(CreationRoutine(CreateFlyweightCar));
        }

        void CreateDefaultCar()
        {
            var car = new GameObject("Default Car").AddComponent<DefaultCar>();

            car.Color = GetRandomColor();
            car.WheelColor = GetRandomColor();
            car.ModelName = GetRandomName();
            car.Sprite = GetRandomSprite();
        }

        void CreateFlyweightCar()
        {
            var car = new GameObject("Flyweight Car").AddComponent<FlyweightCar>();
            var flyweight = _flyweightFactory.GetFlyweightData(
                GetRandomName(), GetRandomSprite(),
                GetRandomColor(), GetRandomColor());

            car.FlyweightData = flyweight;
        }

        IEnumerator CreationRoutine(Action creationMethod)
        {
            var frames = _testCount / Mathf.Clamp(_countPerFrame, 1, int.MaxValue);

            for (int i = 0; i < frames; i++)
            {
                for (int j = 0; j < _countPerFrame; j++)
                {
                    creationMethod.Invoke();
                }

                yield return null;
            }

            yield return new WaitForSeconds(1);
            GC.Collect();
        }

        #region Utility

        Color GetRandomColor()
        {
            return _possibleColors[Random.Range(0, _possibleColors.Length)];
        }

        string GetRandomName()
        {
            return _possibleNames[Random.Range(0, _possibleNames.Length)];
        }

        Sprite GetRandomSprite()
        { 
            return _possibleSprites[Random.Range(0, _possibleSprites.Length)];
        }

        #endregion
    }
}
