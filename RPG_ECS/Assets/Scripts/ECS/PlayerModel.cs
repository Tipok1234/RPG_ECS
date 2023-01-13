using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;
using Voody.UniLeo;
using System;

namespace Assets.Scripts.ECS
{
    [Serializable]
    public struct PlayerModel 
    {
        public Transform _myPos;
        public float _moveSpeed;
        public float _rangeAttack;
        public float _damage;

        public Vector3 _direction;
    }
}
