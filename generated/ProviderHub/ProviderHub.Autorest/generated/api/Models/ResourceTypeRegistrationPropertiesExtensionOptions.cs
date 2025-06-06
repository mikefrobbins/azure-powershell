// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class ResourceTypeRegistrationPropertiesExtensionOptions :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistrationPropertiesExtensionOptions,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistrationPropertiesExtensionOptionsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptions"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptions __resourceTypeExtensionOptions = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ResourceTypeExtensionOptions();

        /// <summary>Internal Acessors for ResourceCreationBegin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsResourceCreationBegin Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal.ResourceCreationBegin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBegin; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBegin = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsResourceCreationBegin ResourceCreationBegin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBegin; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBegin = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceCreationBeginRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBeginRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBeginRequest = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceCreationBeginResponse { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBeginResponse; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal)__resourceTypeExtensionOptions).ResourceCreationBeginResponse = value ?? null /* arrayOf */; }

        /// <summary>
        /// Creates an new <see cref="ResourceTypeRegistrationPropertiesExtensionOptions" /> instance.
        /// </summary>
        public ResourceTypeRegistrationPropertiesExtensionOptions()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceTypeExtensionOptions), __resourceTypeExtensionOptions);
            await eventListener.AssertObjectIsValid(nameof(__resourceTypeExtensionOptions), __resourceTypeExtensionOptions);
        }
    }
    public partial interface IResourceTypeRegistrationPropertiesExtensionOptions :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptions
    {

    }
    internal partial interface IResourceTypeRegistrationPropertiesExtensionOptionsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeExtensionOptionsInternal
    {

    }
}