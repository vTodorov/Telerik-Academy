
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Display
    {
        private float size;
        private int numbersOFColors;

        public float Size
        {
            get
            {
                return this.size;
            }


          private  set
            {
                if (value < 0)
                {
                    throw new FormatException("Display size have to be positive float");
                }
                this.size = value;
            }

        }

        public int NumberOfColors
        {
            get
            {
                return this.numbersOFColors;
            }


            set
            {
                if (value < 0)
                {
                    throw new FormatException("numbersOFColors have to be positive int");
                }
                this.numbersOFColors = value;
            }
        }



        public Display()
        {

        }
        public Display(float displaySize, int displayNumberOfColors)
        {
            this.Size = displaySize;
            this.NumberOfColors = displayNumberOfColors;
        }


    }
}
