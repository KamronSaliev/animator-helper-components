using Parameters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ParameterSetters
{
    public class IntParametersSetter : ParameterBaseSetter
    {
        [SerializeField] [ListDrawerSettings(ShowPaging = false)]
        private AnimatorParameter<int>[] _parameters;

        protected override void UpdateParameter(Animator animator)
        {
            for (var i = 0; i < _parameters.Length; i++)
            {
                animator.SetInteger(_parameters[i].Name, _parameters[i].Value);
            }
        }
    }
}