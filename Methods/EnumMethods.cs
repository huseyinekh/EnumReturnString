using EnumReturnString.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace EnumReturnString.Methods
{
    public static class EnumMethods<T> where T : Enum
    {
        public static string ToDescriptionString(T val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
        public static string? ToDisplayString(T enumVal)
        {
            try
            {
                var enumType = typeof(T);
                var memberInfos =
                enumType.GetMember(enumVal.ToString());
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m =>
                m.DeclaringType == enumType);
                var valueAttributes =
                enumValueMemberInfo.GetCustomAttributes(typeof(DisplayAttribute), false);
                var display = ((DisplayAttribute)valueAttributes[0]).Name;
         
                return display;
            }
            catch
            {
               
                return enumVal.ToString();
            }
        }
    }


}
