using Parameters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ParameterSetters
{
    public class BoolParametersSetter : ParameterBaseSetter
    {
        [SerializeField] [ListDrawerSettings(ShowPaging = false)]
        private AnimatorParameter<bool>[] _parameters;

        protected override void UpdateParameter(Animator animator)
        {
            for (var i = 0; i < _parameters.Length; i++)
            {
                animator.SetBool(_parameters[i].Name, _parameters[i].Value);
            }
        }
    }
}