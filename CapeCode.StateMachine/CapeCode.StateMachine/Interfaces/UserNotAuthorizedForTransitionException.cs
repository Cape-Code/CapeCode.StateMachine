using System;

namespace CapeCode.StateMachine.Interfaces {
    public class UserNotAuthorizedForTransitionException : Exception {

        public UserNotAuthorizedForTransitionException( string message, Exception innerException )
            : base( message, innerException ) {

        }

        public UserNotAuthorizedForTransitionException( string message )
            : base( message ) {

        }

        public UserNotAuthorizedForTransitionException()
            : base() {

        }

    }
}
