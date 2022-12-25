using System;
using UnityEngine;

namespace Parameters
{
    [Serializable]
    public class AnimatorParameter<T>
    {
        [SerializeField] private string _name;

        [SerializeField] private T _value;

        public string Name => _name;

        public T Value => _value;
    }
}