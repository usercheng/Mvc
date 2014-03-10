// <auto-generated />
namespace Microsoft.AspNet.Mvc.Rendering
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Mvc.Rendering.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The model item passed is null, but this ViewData instance requires a non-null model item of type '{0}'.
        /// </summary>
        internal static string ViewData_ModelCannotBeNull
        {
            get { return GetString("ViewData_ModelCannotBeNull"); }
        }

        /// <summary>
        /// The model item passed is null, but this ViewData instance requires a non-null model item of type '{0}'.
        /// </summary>
        internal static string FormatViewData_ModelCannotBeNull(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewData_ModelCannotBeNull"), p0);
        }

        /// <summary>
        /// The model item passed into the ViewData is of type '{0}', but this ViewData instance requires a model item of type '{1}'.
        /// </summary>
        internal static string ViewData_WrongTModelType
        {
            get { return GetString("ViewData_WrongTModelType"); }
        }

        /// <summary>
        /// The model item passed into the ViewData is of type '{0}', but this ViewData instance requires a model item of type '{1}'.
        /// </summary>
        internal static string FormatViewData_WrongTModelType(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ViewData_WrongTModelType"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);
    
            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}