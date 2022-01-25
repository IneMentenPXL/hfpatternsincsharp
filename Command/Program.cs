using System;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOn lightOn = new LightOn(light);
            LightOff lightOff = new LightOff(light);

            remote.SetCommand(0, lightOn, lightOff);
            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);

            GarageDoor door = new GarageDoor();
            GarageDoorOpen doorOpen = new GarageDoorOpen(door);
            GarageDoorClose doorClose = new GarageDoorClose(door);

            remote.SetCommand(1, doorOpen, doorClose);
            remote.OnButtonWasPressed(1);
            Console.WriteLine(remote);
            remote.OffButtonWasPressed(1);
            Console.WriteLine(remote);
            remote.UndoButtonWasPressed();
            remote.OffButtonWasPressed(1);
            Console.WriteLine(remote);
            Console.ReadLine();
        }
    }

    public class SimpleRemoteControl
    {
        public const int APP_COUNT = 7;

        // we are modeling a remote control where
        // one button push equals activating a device and
        // another button push equals deactivating the device.
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public SimpleRemoteControl()
        {
            onCommands = new ICommand[APP_COUNT];
            offCommands = new ICommand[APP_COUNT];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i != APP_COUNT; ++i)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("\n--- Remote Control ---\n");
            for (int i = 0; i != onCommands.Length; ++i)
                output.AppendFormat("[slot {0}] {1} {2}\n",
                    i, onCommands[i].GetType().Name, offCommands[i].GetType().Name);
            output.AppendFormat("[undo] {0}", undoCommand.GetType().Name);
            return output.ToString();
        }
    }
}
