using System;

namespace CapeCode.StateMachine.Interfaces {
    [AttributeUsage( AttributeTargets.Method )]
    public class TransitionAfterExecuteMethodAttribute : Attribute {

        public object TransitionDefinitionName { get; set; }


    }
}
