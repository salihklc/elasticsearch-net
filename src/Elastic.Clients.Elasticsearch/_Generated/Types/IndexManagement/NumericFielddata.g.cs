// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class NumericFielddata
	{
		[JsonInclude]
		[JsonPropertyName("format")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddataFormat Format { get; set; }
	}

	public sealed partial class NumericFielddataDescriptor : SerializableDescriptorBase<NumericFielddataDescriptor>
	{
		internal NumericFielddataDescriptor(Action<NumericFielddataDescriptor> configure) => configure.Invoke(this);
		public NumericFielddataDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddataFormat FormatValue { get; set; }

		public NumericFielddataDescriptor Format(Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddataFormat format)
		{
			FormatValue = format;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("format");
			JsonSerializer.Serialize(writer, FormatValue, options);
			writer.WriteEndObject();
		}
	}
}