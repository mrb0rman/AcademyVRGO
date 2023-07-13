using UnityEngine;

namespace Script.Game
{
    public class Player : Observable
    {
        [SerializeField] private MeshFilter _meshFilter;
        public MeshFilter MeshFilter => _meshFilter;
    }
}