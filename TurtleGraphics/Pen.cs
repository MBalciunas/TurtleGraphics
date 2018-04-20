using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGraphics
{
    public class Pen
    {
        public enum PenActions
        {
            Up = 1,
            Down = 2
        };

        public Pen()
        {
            PenAction = PenActions.Up;
        }

        private PenActions _penActions;

        public PenActions PenAction
        {
            get { return _penActions; }
            set
            {
                switch ((int)value)
                {
                    case 1:
                        _penActions = PenActions.Up;
                        break;
                    case 2: 
                        _penActions = PenActions.Down;
                        break;
                    default:
                        Messages.InvalidInput();
                        break;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Pen is currently {0}", PenAction == PenActions.Down ? "DRAWING" : "NOT DRAWING");
        }
    }
}
