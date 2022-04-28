using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs.CreationalPatterns.Prototype
{
    //usage 3/5
    #region Prototype
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
    #endregion

    #region Concrete Prototype
    public class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype Clone()
        {
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
    #endregion

    #region Prototype manager
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string,ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors[key] = value; }
        }
    }
    #endregion
}
