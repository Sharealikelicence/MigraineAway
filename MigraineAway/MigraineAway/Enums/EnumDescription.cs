using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace MigraineAway.Enums
{
    public static class EnumDescription
    {
        /// <summary>
        /// Gets the human readable version of an enum
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="en">the enum value</param>
        /// <returns>String representation of enum value</returns>
        public static string Get<T>(this T en) where T : struct
        {
            Type type = en.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(en.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return en.ToString();
        }
    }
}
