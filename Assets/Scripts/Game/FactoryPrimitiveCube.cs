using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Script.Game
{
    public class FactoryPrimitiveCube 
    {
        //загружаешь из ресурсов
        PrimitiveConfig _primitiveConfig;
        public Player Create(PrimitiveForm form)
        {
            //GameObject gameObject = new GameObject();
            //gameObject.transform.localScale = primitive.size;
            //var model =  _primitiveConfig.get(form)
            //var player = GameObject.InstantiatePrefab(PREFAB); можешь загружать из ресорсов
            //player.mesh = model.mesh
            //resources.load<primtiveConfig>()
            //player.sprite = model.sprite
            //plaer.sped = model.speed
            
            _primitiveConfig = Resources.Load<PrimitiveConfig>("PrimitiveConfig");
            var player = GameObject.Instantiate(Resources.Load<Player>("Player"));
            var model = _primitiveConfig.Get(form);
            player.MeshFilter.mesh = model.mesh;
            player.gameObject.transform.localScale = model.size;
            
            return player;
        }
    }
}