using System;

namespace CapeCode.StateMachine.Interfaces {
    public class StateMachineValidationException : Exception {
        //public StateMachineValidationException( string message, Exception innerException )
        //    : base( message, innerException ) {

        //}

        public StateMachineValidationException( string message )
            : base( message ) {

        }
    }
}
