using System;

namespace CapeCode.StateMachine.Interfaces {
    [AttributeUsage( AttributeTargets.Method, AllowMultiple = true )]
    public class TransitionActionViewMethodAttribute : Attribute {

        public object TransitionDefinitionName { get; set; }

    }
}
