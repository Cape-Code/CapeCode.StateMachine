using System;

namespace CapeCode.StateMachine.Interfaces {
    [AttributeUsage( AttributeTargets.Method )]
    public class TransitionIsValidMethodAttribute : Attribute {

        public object TransitionDefinitionName { get; set; }


    }
}
