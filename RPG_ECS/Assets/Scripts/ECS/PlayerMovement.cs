using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ECS
{
    public class PlayerMovement : IEcsInitSystem, IEcsRunSystem
    {
        //private EcsWorld _world = null;
        private EcsFilter<PlayerModel> _filter = null;
        public void Init()
        {
         
        }

        public void Run()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");

            foreach (var i in _filter)
            {
                var move = _filter.Get1(i);

                move._direction = new Vector3(x,0,y);

                move._myPos.position += (Vector3)move._direction * (Time.deltaTime * move._moveSpeed); 
            }
        }
    }
}
