using System;

namespace CapeCode.StateMachine.Interfaces {
    [AttributeUsage( AttributeTargets.Method )]
    public class TransitionExecuteMethodAttribute : Attribute {

        public object TransitionDefinitionName { get; set; }


    }
}
