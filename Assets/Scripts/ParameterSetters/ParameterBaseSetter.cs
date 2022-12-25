using Parameters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ParameterSetters
{
    public abstract class ParameterBaseSetter : SerializedStateMachineBehaviour
    {
        [SerializeField] protected StateMachineBehaviorEvent _stateEvent = StateMachineBehaviorEvent.OnEnter;

        protected abstract void UpdateParameter(Animator animator);

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (_stateEvent == StateMachineBehaviorEvent.OnEnter)
            {
                UpdateParameter(animator);
            }
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (_stateEvent == StateMachineBehaviorEvent.OnExit)
            {
                UpdateParameter(animator);
            }
        }
    }
}