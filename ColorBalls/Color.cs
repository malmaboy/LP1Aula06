namespace ColorBalls
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }


        public Color(byte red,byte green, byte blue)
        {
               this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 255;
        }

        // Metodo getter and setter (getter) 
        public byte GetRed()
        {
            return red;
        }
        // Metodo getter and setter (setter)
        public void SetRed(byte red)
        {
            this.red = red;
        }

        // getter and setter for blue
        public byte GetBlue()
        {
            return blue;
        }
        public void SetBlue()
        {
            this.blue = blue;
        }

        // metodo getter and setter for green
        public byte GetGreen()
        {
            return green;
        }
        public void SetGreen()
        {
            this.green = green;
        }

        public byte GetAlpha()
        {
            return alpha;
        }
        public void SetAlpha()
        {
            this.alpha = alpha;
        }

        public byte SetGrey()
        {
            // Conversão de int para byte returnado um byte
            return (byte)((red + blue + green) / 3);
        }


    }
}