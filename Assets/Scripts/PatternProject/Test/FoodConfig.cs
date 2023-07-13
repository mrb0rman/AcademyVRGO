using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Test
{
    [CreateAssetMenu(fileName = "FoodConfig", menuName = "Configs/FoodConfig", order = 1)]
    public class FoodConfig : ScriptableObject
    {
        [SerializeField] private FoodModel[] models;
    
        [NonSerialized] private bool _inited;

        private Dictionary<FoodType, FoodModel> _dictionary = new Dictionary<FoodType, FoodModel>();

        private void Init()
        {
            foreach (var model in models)
            {
                _dictionary.Add(model.FoodType, model);
            }
        }

        public FoodModel Get(FoodType type)
        {
            if (!_inited)
            {
                Init();
            }

            return _dictionary[type];
        }
    }

    [Serializable]
    public struct FoodModel
    {
        public FoodType FoodType;
        public Sprite SpriteRenderer;
        public int Condition1;
        public int Condition2;
    }

    public enum FoodType
    {
        Apple,
        Banana,
        Orange
    }
}