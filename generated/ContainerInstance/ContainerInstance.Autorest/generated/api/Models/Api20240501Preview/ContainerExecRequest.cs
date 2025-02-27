// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>The container exec request.</summary>
    public partial class ContainerExecRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestInternal
    {

        /// <summary>Backing field for <see cref="Command" /> property.</summary>
        private string _command;

        /// <summary>The command to be executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Command { get => this._command; set => this._command = value; }

        /// <summary>Internal Acessors for TerminalSize</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSize Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestInternal.TerminalSize { get => (this._terminalSize = this._terminalSize ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ContainerExecRequestTerminalSize()); set { {_terminalSize = value;} } }

        /// <summary>Backing field for <see cref="TerminalSize" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSize _terminalSize;

        /// <summary>The size of the terminal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSize TerminalSize { get => (this._terminalSize = this._terminalSize ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ContainerExecRequestTerminalSize()); set => this._terminalSize = value; }

        /// <summary>The column size of the terminal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? TerminalSizeCol { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSizeInternal)TerminalSize).Col; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSizeInternal)TerminalSize).Col = value ?? default(int); }

        /// <summary>The row size of the terminal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? TerminalSizeRow { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSizeInternal)TerminalSize).Row; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSizeInternal)TerminalSize).Row = value ?? default(int); }

        /// <summary>Creates an new <see cref="ContainerExecRequest" /> instance.</summary>
        public ContainerExecRequest()
        {

        }
    }
    /// The container exec request.
    public partial interface IContainerExecRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The command to be executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The command to be executed.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string Command { get; set; }
        /// <summary>The column size of the terminal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The column size of the terminal",
        SerializedName = @"cols",
        PossibleTypes = new [] { typeof(int) })]
        int? TerminalSizeCol { get; set; }
        /// <summary>The row size of the terminal</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The row size of the terminal",
        SerializedName = @"rows",
        PossibleTypes = new [] { typeof(int) })]
        int? TerminalSizeRow { get; set; }

    }
    /// The container exec request.
    internal partial interface IContainerExecRequestInternal

    {
        /// <summary>The command to be executed.</summary>
        string Command { get; set; }
        /// <summary>The size of the terminal.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.IContainerExecRequestTerminalSize TerminalSize { get; set; }
        /// <summary>The column size of the terminal</summary>
        int? TerminalSizeCol { get; set; }
        /// <summary>The row size of the terminal</summary>
        int? TerminalSizeRow { get; set; }

    }
}