// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace Microsoft.AspNet.Mvc.ModelBinding.Internal
{
    internal static class ModelBindingContextExtensions
    {
        public static IEnumerable<IModelValidator> GetValidators([NotNull] this ModelBindingContext context, 
                                                                 [NotNull] ModelMetadata metadata)
        {
            return context.ValidatorProviders.SelectMany(vp => vp.GetValidators(metadata))
                                             .Where(v => v != null);
        }

        public static IEnumerable<ModelValidationResult> Validate([NotNull] this ModelBindingContext bindingContext)
        {
            var validators = GetValidators(bindingContext, bindingContext.ModelMetadata);
            var compositeValidator = new CompositeModelValidator(validators);
            var modelValidationContext = new ModelValidationContext(bindingContext, bindingContext.ModelMetadata);
            return compositeValidator.Validate(modelValidationContext);
        }
    }
}
