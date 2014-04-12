// <auto-generated />
namespace Microsoft.AspNet.Mvc.ModelBinding
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Mvc.ModelBinding.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// The value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// The property {0}.{1} could not be found.
        /// </summary>
        internal static string Common_PropertyNotFound
        {
            get { return GetString("Common_PropertyNotFound"); }
        }

        /// <summary>
        /// The property {0}.{1} could not be found.
        /// </summary>
        internal static string FormatCommon_PropertyNotFound(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Common_PropertyNotFound"), p0, p1);
        }

        /// <summary>
        /// The type '{0}' must have a public constructor which accepts a single parameter of type '{1}'.
        /// </summary>
        internal static string DataAnnotationsModelValidatorProvider_ConstructorRequirements
        {
            get { return GetString("DataAnnotationsModelValidatorProvider_ConstructorRequirements"); }
        }

        /// <summary>
        /// The type '{0}' must have a public constructor which accepts a single parameter of type '{1}'.
        /// </summary>
        internal static string FormatDataAnnotationsModelValidatorProvider_ConstructorRequirements(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DataAnnotationsModelValidatorProvider_ConstructorRequirements"), p0, p1);
        }

        /// <summary>
        /// The key is invalid JQuery syntax because it is missing a closing bracket.
        /// </summary>
        internal static string JQuerySyntaxMissingClosingBracket
        {
            get { return GetString("JQuerySyntaxMissingClosingBracket"); }
        }

        /// <summary>
        /// The key is invalid JQuery syntax because it is missing a closing bracket.
        /// </summary>
        internal static string FormatJQuerySyntaxMissingClosingBracket()
        {
            return GetString("JQuerySyntaxMissingClosingBracket");
        }

        /// <summary>
        /// No encoding found for input formatter '{0}'. There must be at least one supported encoding registered in order for the formatter to read content.
        /// </summary>
        internal static string MediaTypeFormatterNoEncoding
        {
            get { return GetString("MediaTypeFormatterNoEncoding"); }
        }

        /// <summary>
        /// No encoding found for input formatter '{0}'. There must be at least one supported encoding registered in order for the formatter to read content.
        /// </summary>
        internal static string FormatMediaTypeFormatterNoEncoding(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MediaTypeFormatterNoEncoding"), p0);
        }

        /// <summary>
        /// Property '{0}' on type '{1}' is invalid. Value-typed properties marked as [Required] must also be marked with [DataMember(IsRequired=true)] to be recognized as required. Consider attributing the declaring type with [DataContract] and the property with [DataMember(IsRequired=true)].
        /// </summary>
        internal static string MissingDataMemberIsRequired
        {
            get { return GetString("MissingDataMemberIsRequired"); }
        }

        /// <summary>
        /// Property '{0}' on type '{1}' is invalid. Value-typed properties marked as [Required] must also be marked with [DataMember(IsRequired=true)] to be recognized as required. Consider attributing the declaring type with [DataContract] and the property with [DataMember(IsRequired=true)].
        /// </summary>
        internal static string FormatMissingDataMemberIsRequired(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MissingDataMemberIsRequired"), p0, p1);
        }

        /// <summary>
        /// The '{0}' property is required.
        /// </summary>
        internal static string MissingRequiredMember
        {
            get { return GetString("MissingRequiredMember"); }
        }

        /// <summary>
        /// The '{0}' property is required.
        /// </summary>
        internal static string FormatMissingRequiredMember(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MissingRequiredMember"), p0);
        }

        /// <summary>
        /// The value '{0}' is not valid for {1}.
        /// </summary>
        internal static string ModelBinderConfig_ValueInvalid
        {
            get { return GetString("ModelBinderConfig_ValueInvalid"); }
        }

        /// <summary>
        /// The value '{0}' is not valid for {1}.
        /// </summary>
        internal static string FormatModelBinderConfig_ValueInvalid(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModelBinderConfig_ValueInvalid"), p0, p1);
        }

        /// <summary>
        /// A value is required.
        /// </summary>
        internal static string ModelBinderConfig_ValueRequired
        {
            get { return GetString("ModelBinderConfig_ValueRequired"); }
        }

        /// <summary>
        /// A value is required.
        /// </summary>
        internal static string FormatModelBinderConfig_ValueRequired()
        {
            return GetString("ModelBinderConfig_ValueRequired");
        }

        /// <summary>
        /// The binding context has a null Model, but this binder requires a non-null model of type '{0}'.
        /// </summary>
        internal static string ModelBinderUtil_ModelCannotBeNull
        {
            get { return GetString("ModelBinderUtil_ModelCannotBeNull"); }
        }

        /// <summary>
        /// The binding context has a null Model, but this binder requires a non-null model of type '{0}'.
        /// </summary>
        internal static string FormatModelBinderUtil_ModelCannotBeNull(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModelBinderUtil_ModelCannotBeNull"), p0);
        }

        /// <summary>
        /// The binding context has a Model of type '{0}', but this binder can only operate on models of type '{1}'.
        /// </summary>
        internal static string ModelBinderUtil_ModelInstanceIsWrong
        {
            get { return GetString("ModelBinderUtil_ModelInstanceIsWrong"); }
        }

        /// <summary>
        /// The binding context has a Model of type '{0}', but this binder can only operate on models of type '{1}'.
        /// </summary>
        internal static string FormatModelBinderUtil_ModelInstanceIsWrong(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModelBinderUtil_ModelInstanceIsWrong"), p0, p1);
        }

        /// <summary>
        /// The binding context cannot have a null ModelMetadata.
        /// </summary>
        internal static string ModelBinderUtil_ModelMetadataCannotBeNull
        {
            get { return GetString("ModelBinderUtil_ModelMetadataCannotBeNull"); }
        }

        /// <summary>
        /// The binding context cannot have a null ModelMetadata.
        /// </summary>
        internal static string FormatModelBinderUtil_ModelMetadataCannotBeNull()
        {
            return GetString("ModelBinderUtil_ModelMetadataCannotBeNull");
        }

        /// <summary>
        /// The binding context has a ModelType of '{0}', but this binder can only operate on models of type '{1}'.
        /// </summary>
        internal static string ModelBinderUtil_ModelTypeIsWrong
        {
            get { return GetString("ModelBinderUtil_ModelTypeIsWrong"); }
        }

        /// <summary>
        /// The binding context has a ModelType of '{0}', but this binder can only operate on models of type '{1}'.
        /// </summary>
        internal static string FormatModelBinderUtil_ModelTypeIsWrong(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModelBinderUtil_ModelTypeIsWrong"), p0, p1);
        }

        /// <summary>
        /// The ModelMetadata property must be set before accessing this property.
        /// </summary>
        internal static string ModelBindingContext_ModelMetadataMustBeSet
        {
            get { return GetString("ModelBindingContext_ModelMetadataMustBeSet"); }
        }

        /// <summary>
        /// The ModelMetadata property must be set before accessing this property.
        /// </summary>
        internal static string FormatModelBindingContext_ModelMetadataMustBeSet()
        {
            return GetString("ModelBindingContext_ModelMetadataMustBeSet");
        }

        /// <summary>
        /// The type '{0}' must derive from '{1}'.
        /// </summary>
        internal static string TypeMustDeriveFromType
        {
            get { return GetString("TypeMustDeriveFromType"); }
        }

        /// <summary>
        /// The type '{0}' must derive from '{1}'.
        /// </summary>
        internal static string FormatTypeMustDeriveFromType(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TypeMustDeriveFromType"), p0, p1);
        }

        /// <summary>
        /// The model object inside the metadata claimed to be compatible with '{0}', but was actually '{1}'.
        /// </summary>
        internal static string ValidatableObjectAdapter_IncompatibleType
        {
            get { return GetString("ValidatableObjectAdapter_IncompatibleType"); }
        }

        /// <summary>
        /// The model object inside the metadata claimed to be compatible with '{0}', but was actually '{1}'.
        /// </summary>
        internal static string FormatValidatableObjectAdapter_IncompatibleType(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValidatableObjectAdapter_IncompatibleType"), p0, p1);
        }

        /// <summary>
        /// Field '{0}' on type '{1}' is attributed with one or more validation attributes. Validation attributes on fields are not supported. Consider using a public property for validation instead.
        /// </summary>
        internal static string ValidationAttributeOnField
        {
            get { return GetString("ValidationAttributeOnField"); }
        }

        /// <summary>
        /// Field '{0}' on type '{1}' is attributed with one or more validation attributes. Validation attributes on fields are not supported. Consider using a public property for validation instead.
        /// </summary>
        internal static string FormatValidationAttributeOnField(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValidationAttributeOnField"), p0, p1);
        }

        /// <summary>
        /// Non-public property '{0}' on type '{1}' is attributed with one or more validation attributes. Validation attributes on non-public properties are not supported. Consider using a public property for validation instead.
        /// </summary>
        internal static string ValidationAttributeOnNonPublicProperty
        {
            get { return GetString("ValidationAttributeOnNonPublicProperty"); }
        }

        /// <summary>
        /// Non-public property '{0}' on type '{1}' is attributed with one or more validation attributes. Validation attributes on non-public properties are not supported. Consider using a public property for validation instead.
        /// </summary>
        internal static string FormatValidationAttributeOnNonPublicProperty(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValidationAttributeOnNonPublicProperty"), p0, p1);
        }

        /// <summary>
        /// A field previously marked invalid should not be marked valid.
        /// </summary>
        internal static string Validation_InvalidFieldCannotBeReset
        {
            get { return GetString("Validation_InvalidFieldCannotBeReset"); }
        }

        /// <summary>
        /// A field previously marked invalid should not be marked valid.
        /// </summary>
        internal static string FormatValidation_InvalidFieldCannotBeReset()
        {
            return GetString("Validation_InvalidFieldCannotBeReset");
        }

        /// <summary>
        /// A value is required but was not present in the request.
        /// </summary>
        internal static string Validation_ValueNotFound
        {
            get { return GetString("Validation_ValueNotFound"); }
        }

        /// <summary>
        /// A value is required but was not present in the request.
        /// </summary>
        internal static string FormatValidation_ValueNotFound()
        {
            return GetString("Validation_ValueNotFound");
        }

        /// <summary>
        /// Cannot convert value '{0}' to enum type '{1}'.
        /// </summary>
        internal static string ValueProviderResult_CannotConvertEnum
        {
            get { return GetString("ValueProviderResult_CannotConvertEnum"); }
        }

        /// <summary>
        /// Cannot convert value '{0}' to enum type '{1}'.
        /// </summary>
        internal static string FormatValueProviderResult_CannotConvertEnum(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValueProviderResult_CannotConvertEnum"), p0, p1);
        }

        /// <summary>
        /// The parameter conversion from type '{0}' to type '{1}' failed. See the inner exception for more information.
        /// </summary>
        internal static string ValueProviderResult_ConversionThrew
        {
            get { return GetString("ValueProviderResult_ConversionThrew"); }
        }

        /// <summary>
        /// The parameter conversion from type '{0}' to type '{1}' failed. See the inner exception for more information.
        /// </summary>
        internal static string FormatValueProviderResult_ConversionThrew(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValueProviderResult_ConversionThrew"), p0, p1);
        }

        /// <summary>
        /// The parameter conversion from type '{0}' to type '{1}' failed because no type converter can convert between these types.
        /// </summary>
        internal static string ValueProviderResult_NoConverterExists
        {
            get { return GetString("ValueProviderResult_NoConverterExists"); }
        }

        /// <summary>
        /// The parameter conversion from type '{0}' to type '{1}' failed because no type converter can convert between these types.
        /// </summary>
        internal static string FormatValueProviderResult_NoConverterExists(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ValueProviderResult_NoConverterExists"), p0, p1);
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
