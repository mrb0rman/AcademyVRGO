using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Game
{
    [CreateAssetMenu(fileName = "PrimitiveConfig", menuName = "Configs/PrimitiveConfig", order = 0)]
    public class PrimitiveConfig : ScriptableObject
    {
        [SerializeField] private Primitive[] primitives;

        [NonSerialized] private bool _inited;
        
        private Dictionary<PrimitiveForm, Primitive> dictForm = new Dictionary<PrimitiveForm, Primitive>();
        
        public void Init()
        {
            foreach (var primitive in primitives)
            {
                dictForm.Add(primitive.form, primitive);
            }
        }

        public Primitive Get(PrimitiveForm form)
        {
            if (!_inited)
            {
                Init();
            }
            return dictForm[form];
        }
    }
    
    [Serializable]
    public struct Primitive
    {
        public PrimitiveForm form;
        public Vector3 size;
        public Mesh mesh;
    }
    
    public enum PrimitiveForm
    {
        SmallCube,
        BigCube,
        Sphere,
        Cylinder
    }
}