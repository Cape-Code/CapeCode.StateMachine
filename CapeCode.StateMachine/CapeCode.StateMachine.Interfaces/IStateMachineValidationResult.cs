using System.Collections.Generic;

namespace CapeCode.StateMachine.Interfaces {
    public interface IStateMachineValidationResult {

        ICollection<string> Errors { get; }

        ICollection<string> Warnings { get; }

    }
}
