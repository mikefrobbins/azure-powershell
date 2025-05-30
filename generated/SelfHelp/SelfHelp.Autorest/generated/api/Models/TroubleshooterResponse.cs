// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Extensions;

    /// <summary>User Response for Troubleshooter continue request</summary>
    public partial class TroubleshooterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITroubleshooterResponse,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITroubleshooterResponseInternal
    {

        /// <summary>Backing field for <see cref="QuestionId" /> property.</summary>
        private string _questionId;

        /// <summary>id of the question.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string QuestionId { get => this._questionId; set => this._questionId = value; }

        /// <summary>Backing field for <see cref="QuestionType" /> property.</summary>
        private string _questionType;

        /// <summary>Type of Question</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string QuestionType { get => this._questionType; set => this._questionType = value; }

        /// <summary>Backing field for <see cref="Response" /> property.</summary>
        private string _response;

        /// <summary>
        /// Response key for SingleInput. For Multi-line test/open ended question it is free form text
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Response { get => this._response; set => this._response = value; }

        /// <summary>Creates an new <see cref="TroubleshooterResponse" /> instance.</summary>
        public TroubleshooterResponse()
        {

        }
    }
    /// User Response for Troubleshooter continue request
    public partial interface ITroubleshooterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IJsonSerializable
    {
        /// <summary>id of the question.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"id of the question.",
        SerializedName = @"questionId",
        PossibleTypes = new [] { typeof(string) })]
        string QuestionId { get; set; }
        /// <summary>Type of Question</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Question",
        SerializedName = @"questionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("RadioButton", "Dropdown", "TextInput", "MultiLineInfoBox", "DateTimePicker", "MultiSelect")]
        string QuestionType { get; set; }
        /// <summary>
        /// Response key for SingleInput. For Multi-line test/open ended question it is free form text
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Response key for SingleInput. For Multi-line test/open ended question it is free form text",
        SerializedName = @"response",
        PossibleTypes = new [] { typeof(string) })]
        string Response { get; set; }

    }
    /// User Response for Troubleshooter continue request
    internal partial interface ITroubleshooterResponseInternal

    {
        /// <summary>id of the question.</summary>
        string QuestionId { get; set; }
        /// <summary>Type of Question</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("RadioButton", "Dropdown", "TextInput", "MultiLineInfoBox", "DateTimePicker", "MultiSelect")]
        string QuestionType { get; set; }
        /// <summary>
        /// Response key for SingleInput. For Multi-line test/open ended question it is free form text
        /// </summary>
        string Response { get; set; }

    }
}