using System;
using System.ComponentModel;

namespace Task3.KeyEvents
{
    //used to process the key
    class NewKeyEventArgs : HandledEventArgs
    {
        public ConsoleKeyInfo key;

        public NewKeyEventArgs(ConsoleKeyInfo _key)
        {
            key = _key;
        }
    }

    class KeyEvent
    {
        // press event
        public event EventHandler<NewKeyEventArgs> KeyPress;

        // start the event
        public void OnKeyPress(ConsoleKeyInfo _key)
        {
            KeyPress(this, new NewKeyEventArgs(_key));
        }
    }

}
