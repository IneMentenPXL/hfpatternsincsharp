using System;

namespace Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }

    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door is stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}
