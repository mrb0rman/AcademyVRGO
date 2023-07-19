using System;
using UnityEngine;

namespace Script.Project
{
    public class Spell : MonoBehaviour
    {
        [SerializeField] private Renderer renderer;

        public Renderer Renderer => renderer;

        public float damage;
        public float speed;
        public float timeLife;
    }

}

