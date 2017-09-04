﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using CapeCode.StateMachine.Interfaces;

namespace CapeCode.StateMachine {
    class StateMachineValidationResult : IStateMachineValidationResult {
        public ICollection<string> Errors { get; private set; }
        public ICollection<string> Warnings { get; private set; }

        public StateMachineValidationResult() {
            this.Errors = new Collection<string>();
            this.Warnings = new Collection<string>();
        }
    }
}
