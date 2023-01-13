using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voody.UniLeo;

namespace Assets.Scripts.ECS
{
    public class GameManager : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _system;

        private void Start()
        {
            _world = new EcsWorld();
            _system = new EcsSystems(_world)
                .ConvertScene()
                .Add(new PlayerMovement());

            _system.Init();
        }

        private void Update()
        {
            _system.Run();
        }

        private void OnDestroy()
        {
            _system.Destroy();
            _world.Destroy();
        }
    }
}
