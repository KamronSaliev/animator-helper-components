using Parameters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ParameterSetters
{
    public class FloatParametersSetter : ParameterBaseSetter
    {
        [SerializeField] [ListDrawerSettings(ShowPaging = false)]
        private AnimatorParameter<float>[] _parameters;

        protected override void UpdateParameter(Animator animator)
        {
            for (var i = 0; i < _parameters.Length; i++)
            {
                animator.SetFloat(_parameters[i].Name, _parameters[i].Value);
            }
        }
    }
}