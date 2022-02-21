using System.Collections.Generic;
using System.Collections;
using System;
using System.Numerics;

namespace Labb_17
{
    public class GameObject
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public float Radius { get; set; }
        public float Rotation { get; set; }

        public bool CollidesWith(IGameObject other)
        {
            return false;
        }
        public interface IGameObject { }
    }
    public class Meteor : GameObject
    {
        public MeteorType Type { get; set; }
        public float ExplotionScale { get; set; }
        public void Meter(MeteorType type)
        {
            Type = type;
        }
        public void Update(GameTime gametime)
        {

        }
        public IEnumerable<Meteor> BreakMeteor(Meteor meteor)
        {
            return null;
        }
    }

    public class MeteorType
    {

    }
    public class GameTime
    {

    }
}