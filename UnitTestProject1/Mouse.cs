using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1
{
    internal class Mouse
    {
        public Mouse()
        { }

        public Light light { get; set; }
        public Button button { get; set; }
        public Scroll scroll { get; set; }
        public Position position { get; set; }


        public Mouse CreateMouse()
        {
            Mouse mouse = new Mouse()
            {
                light = new Light() {Color ="white", IsOn = true },
                button = new Button() { Type = "Left", IsPressed = false },
                position = new Position() { x = "1", y = "2" },
                scroll = new Scroll() { ScrollValue = 0 },
            };

            return mouse;

        }
    }
    
}


