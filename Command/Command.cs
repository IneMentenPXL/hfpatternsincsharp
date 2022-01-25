namespace Command
{
    public class NoCommand : ICommand
    {
        #region ICommand Members

        public void Execute()
        {
        }

        public void Undo()
        {
        }

        #endregion
    }

    public class LightOn : ICommand
    {
        Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        #region ICommand Members

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }

        #endregion
    }

    public class GarageDoorOpen : ICommand
    {
        GarageDoor door;

        public GarageDoorOpen(GarageDoor door)
        {
            this.door = door;
        }

        #region ICommand Members

        public void Execute()
        {
            door.LightOn();
            door.Up();
        }

        public void Undo()
        {
            door.Down();
            door.LightOff();
        }

        #endregion
    }

    public class LightOff : ICommand
    {
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        #region ICommand Members

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }

        #endregion
    }

    public class GarageDoorClose : ICommand
    {
        GarageDoor door;

        public GarageDoorClose(GarageDoor door)
        {
            this.door = door;
        }

        #region ICommand Members

        public void Execute()
        {
            door.Down();
            door.LightOff();
        }

        public void Undo()
        {
            door.LightOn();
            door.Up();
        }

        #endregion
    }
}
