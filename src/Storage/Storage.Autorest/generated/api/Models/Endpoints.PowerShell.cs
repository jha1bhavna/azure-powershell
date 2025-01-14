// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.PowerShell;

    /// <summary>
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(EndpointsTypeConverter))]
    public partial class Endpoints
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Endpoints"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpoints" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpoints DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Endpoints(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Endpoints"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpoints" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpoints DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Endpoints(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Endpoints"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Endpoints(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MicrosoftEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountMicrosoftEndpoints) content.GetValueForProperty("MicrosoftEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpoint, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountMicrosoftEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternetEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountInternetEndpoints) content.GetValueForProperty("InternetEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpoint, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountInternetEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Blob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Blob = (string) content.GetValueForProperty("Blob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Blob, global::System.Convert.ToString);
            }
            if (content.Contains("Queue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Queue = (string) content.GetValueForProperty("Queue",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Queue, global::System.Convert.ToString);
            }
            if (content.Contains("Table"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Table = (string) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Table, global::System.Convert.ToString);
            }
            if (content.Contains("File"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).File = (string) content.GetValueForProperty("File",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).File, global::System.Convert.ToString);
            }
            if (content.Contains("Web"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Web = (string) content.GetValueForProperty("Web",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Web, global::System.Convert.ToString);
            }
            if (content.Contains("Df"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Df = (string) content.GetValueForProperty("Df",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Df, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointBlob = (string) content.GetValueForProperty("MicrosoftEndpointBlob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointBlob, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointQueue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointQueue = (string) content.GetValueForProperty("MicrosoftEndpointQueue",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointQueue, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointTable = (string) content.GetValueForProperty("MicrosoftEndpointTable",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointTable, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointFile = (string) content.GetValueForProperty("MicrosoftEndpointFile",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointFile, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointWeb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointWeb = (string) content.GetValueForProperty("MicrosoftEndpointWeb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointWeb, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointDf"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointDf = (string) content.GetValueForProperty("MicrosoftEndpointDf",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointDf, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointBlob = (string) content.GetValueForProperty("InternetEndpointBlob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointBlob, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointFile = (string) content.GetValueForProperty("InternetEndpointFile",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointFile, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointWeb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointWeb = (string) content.GetValueForProperty("InternetEndpointWeb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointWeb, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointDf"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointDf = (string) content.GetValueForProperty("InternetEndpointDf",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointDf, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Endpoints"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Endpoints(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MicrosoftEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountMicrosoftEndpoints) content.GetValueForProperty("MicrosoftEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpoint, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountMicrosoftEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternetEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountInternetEndpoints) content.GetValueForProperty("InternetEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpoint, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountInternetEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Blob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Blob = (string) content.GetValueForProperty("Blob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Blob, global::System.Convert.ToString);
            }
            if (content.Contains("Queue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Queue = (string) content.GetValueForProperty("Queue",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Queue, global::System.Convert.ToString);
            }
            if (content.Contains("Table"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Table = (string) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Table, global::System.Convert.ToString);
            }
            if (content.Contains("File"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).File = (string) content.GetValueForProperty("File",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).File, global::System.Convert.ToString);
            }
            if (content.Contains("Web"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Web = (string) content.GetValueForProperty("Web",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Web, global::System.Convert.ToString);
            }
            if (content.Contains("Df"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Df = (string) content.GetValueForProperty("Df",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).Df, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointBlob = (string) content.GetValueForProperty("MicrosoftEndpointBlob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointBlob, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointQueue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointQueue = (string) content.GetValueForProperty("MicrosoftEndpointQueue",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointQueue, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointTable = (string) content.GetValueForProperty("MicrosoftEndpointTable",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointTable, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointFile = (string) content.GetValueForProperty("MicrosoftEndpointFile",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointFile, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointWeb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointWeb = (string) content.GetValueForProperty("MicrosoftEndpointWeb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointWeb, global::System.Convert.ToString);
            }
            if (content.Contains("MicrosoftEndpointDf"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointDf = (string) content.GetValueForProperty("MicrosoftEndpointDf",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).MicrosoftEndpointDf, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointBlob = (string) content.GetValueForProperty("InternetEndpointBlob",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointBlob, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointFile = (string) content.GetValueForProperty("InternetEndpointFile",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointFile, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointWeb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointWeb = (string) content.GetValueForProperty("InternetEndpointWeb",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointWeb, global::System.Convert.ToString);
            }
            if (content.Contains("InternetEndpointDf"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointDf = (string) content.GetValueForProperty("InternetEndpointDf",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpointsInternal)this).InternetEndpointDf, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Endpoints" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Endpoints" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IEndpoints FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    [System.ComponentModel.TypeConverter(typeof(EndpointsTypeConverter))]
    public partial interface IEndpoints

    {

    }
}