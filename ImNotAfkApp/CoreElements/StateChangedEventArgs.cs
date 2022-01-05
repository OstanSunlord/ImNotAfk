﻿using ImNotAfkApp.CoreElements.State;
using System;

namespace ImNotAfkApp.CoreElements
{
    public class StateChangedEventArgs : EventArgs
    {
        public StateChangedEventArgs(PROGRAM_STATE state)
        {
            State = state;
        }

        public PROGRAM_STATE State { get; set; }
    }
}