using NaughtyAttributes;
using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class TestScript : MonoBehaviour
    {
#pragma warning disable IDE0040, CS0414
        [Header("Info")]
        [SerializeField] [Multiline] [ReadOnly] string _info = "Test while in Play mode.\nUse memory profiler.";
#pragma warning restore IDE0040, CS0414

        [Header("Settings")]
        [SerializeField] int _testCount = 100000;
        [SerializeField] int _countPerFrame = 5000;

        [Header("Serialized values")]
        [SerializeField] Sprite[] _possibleSprites;
        [SerializeField] Color[] _possibleColors;
        [SerializeField] string[] _possibleNames;

        FlyweightFactory _flyweightFactory;
        FlyweightMemoizerFactory _flyweightMemoizerFactory;
        FlyweightRefFactory _flyweightRefFactory;

        //100K Transforms allocates 58 mb
        //100K MonoBehaviours allocates 42 mb

        [Button]
        void DefaultCreation() 
        {
            //Unity allocates 350 mb.
            //Garbage is arround ~50 mb (400 in total)
            //Have to wait some time before GC removes it.
            StartCoroutine(CreationRoutine(CreateDefaultCar));
        }

        [Button]
        void FlyweightCreation()
        {
            //Unity allocates 350 mb.
            //But string hashes generating ~400 mb of garbage (750 in total).
            //Have to wait some time before GC removes it.
            _flyweightFactory = new FlyweightFactory();
            StartCoroutine(CreationRoutine(CreateFlyweightCar));
        }

        [Button]
        void FlyweightWithMemoizerCreation()
        {
            //Unity allocates 350 mb.
            //Garbage is arround ~150 mb (500 in total)
            //Have to wait some time before GC removes it.
            _flyweightMemoizerFactory = new FlyweightMemoizerFactory();
            StartCoroutine(CreationRoutine(CreateFlyweightMemoizerCar));
        }

        [Button]
        void FlyweightRefCreation()
        {
            //Unity allocates 350 mb.
            //Garbage is arround ~100 mb (450 in total)
            //Have to wait some time before GC removes it.
            _flyweightRefFactory = new FlyweightRefFactory();
            StartCoroutine(CreationRoutine(CreateFlyweightRefCar));
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

        void CreateFlyweightMemoizerCar()
        {
            var car = new GameObject("Flyweight Car").AddComponent<FlyweightCar>();
            var flyweight = _flyweightMemoizerFactory.GetFlyweightData(
                GetRandomName(), GetRandomSprite(),
                GetRandomColor(), GetRandomColor());

            car.FlyweightData = flyweight;
        }

        void CreateFlyweightRefCar()
        {
            var car = new GameObject("Flyweight Car").AddComponent<FlyweightCar>();
            var name = _possibleNames[Random.Range(0, _possibleNames.Length)];
            var sprite = _possibleSprites[Random.Range(0, _possibleSprites.Length)];
            ref var carColor = ref _possibleColors[Random.Range(0, _possibleColors.Length)];
            ref var wheelColor = ref _possibleColors[Random.Range(0, _possibleColors.Length)];
            var flyweight = _flyweightRefFactory.GetFlyweightData(name, sprite, ref carColor, ref wheelColor);

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
