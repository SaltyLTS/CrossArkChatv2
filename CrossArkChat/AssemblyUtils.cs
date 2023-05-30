namespace CrossArkChat
{
    using System;
    using System.IO;
    using System.Reflection;

    public static class AssemblyUtils
    {
        public static string GetAttributePropertyValue(Assembly assembly, Type attributeType, string propertyName)
        {
            Attribute[] customAttributes = (Attribute[])assembly.GetCustomAttributes(attributeType, true);
            if (customAttributes.Length != 0)
            {
                PropertyInfo property = attributeType.GetProperty(propertyName, (Type)typeof(string));
                if (property != null)
                {
                    return (string)((string)property.GetValue(customAttributes[0], null));
                }
            }
            return "?";
        }

        public static string GetBuildDate() =>
            GetBuildDate(Assembly.GetEntryAssembly());

        public static string GetBuildDate(Assembly assembly) =>
            ((assembly == null) || (assembly.get_Location() == null)) ? string.Empty : File.GetLastWriteTime(assembly.get_Location()).ToString();

        public static string GetCompanyName() =>
            GetCompanyName(Assembly.GetEntryAssembly());

        public static string GetCompanyName(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyCompanyAttribute attribute = (AssemblyCompanyAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Company))
                {
                    return attribute.Company;
                }
            }
            return string.Empty;
        }

        public static string GetCopyrightText() =>
            GetCopyrightText(Assembly.GetEntryAssembly());

        public static string GetCopyrightText(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyCopyrightAttribute attribute = (AssemblyCopyrightAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Copyright))
                {
                    return attribute.Copyright;
                }
            }
            return string.Empty;
        }

        public static string GetDescription() =>
            GetDescription(Assembly.GetEntryAssembly());

        public static string GetDescription(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyDescriptionAttribute attribute = (AssemblyDescriptionAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Description))
                {
                    return attribute.Description;
                }
            }
            return string.Empty;
        }

        public static string GetFileVersion() =>
            GetFileVersion(Assembly.GetEntryAssembly());

        public static string GetFileVersion(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyFileVersionAttribute attribute = (AssemblyFileVersionAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Version))
                {
                    return attribute.Version;
                }
            }
            return string.Empty;
        }

        public static string GetProductName() =>
            GetProductName(Assembly.GetEntryAssembly());

        public static string GetProductName(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyProductAttribute attribute = (AssemblyProductAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Product))
                {
                    return attribute.Product;
                }
            }
            return string.Empty;
        }

        public static string GetTitle() =>
            GetTitle(Assembly.GetEntryAssembly());

        public static string GetTitle(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyTitleAttribute attribute = (AssemblyTitleAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Title))
                {
                    return attribute.Title;
                }
            }
            return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().get_CodeBase());
        }

        public static string GetTrademark() =>
            GetTrademark(Assembly.GetEntryAssembly());

        public static string GetTrademark(Assembly assembly)
        {
            object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
            if (customAttributes.Length != 0)
            {
                AssemblyTrademarkAttribute attribute = (AssemblyTrademarkAttribute)customAttributes[0];
                if (!string.IsNullOrWhiteSpace(attribute.Trademark))
                {
                    return attribute.Trademark;
                }
            }
            return string.Empty;
        }

        public static string GetVersion() =>
            GetVersion(Assembly.GetEntryAssembly());

        public static string GetVersion(Assembly assembly) =>
            assembly.GetName().get_Version().ToString();
    }
}

