using System;
using UnityEngine;

namespace Script.Game
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private MeshFilter meshFilter;
        [SerializeField] private Renderer renderer;
        public float HP;
        public float damage;

        public MeshFilter MeshFilter => meshFilter;
        public Renderer Renderer => renderer;
        

    }
}


