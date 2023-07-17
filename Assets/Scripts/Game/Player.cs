using UnityEngine;

namespace Script.Game
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private MeshFilter _meshFilter;
        public MeshFilter MeshFilter => _meshFilter;
    }
}