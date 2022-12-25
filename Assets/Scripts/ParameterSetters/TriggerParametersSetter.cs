using Parameters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ParameterSetters
{
    public class TriggerParametersSetter : ParameterBaseSetter
    {
        [SerializeField] [ListDrawerSettings(ShowPaging = false)]
        private AnimatorParameter<bool>[] _parameters;

        protected override void UpdateParameter(Animator animator)
        {
            for (var i = 0; i < _parameters.Length; i++)
            {
                if (_parameters[i].Value)
                {
                    animator.SetTrigger(_parameters[i].Name);
                }
                else
                {
                    animator.ResetTrigger(_parameters[i].Name);
                }
            }
        }
    }
}