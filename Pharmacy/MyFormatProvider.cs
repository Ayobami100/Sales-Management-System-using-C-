using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class MyFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            // Check whether this is an appropriate callback               
            if (!this.Equals(formatProvider))
                return null;

            //if argument/ value is null we return empty string  
            if (arg == null)
                return null;

            string resultString = arg.ToString();

            //transform resultString any way you want (could do operations based on given format parameter)  

            //return the resultant string  
            return resultString;
        }
    }

}
