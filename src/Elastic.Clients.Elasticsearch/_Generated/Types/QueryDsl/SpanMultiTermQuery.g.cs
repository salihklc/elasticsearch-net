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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanMultiTermQuery : QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "span_multi";
		[JsonIgnore]
		string ISpanQueryVariant.SpanQueryVariantName => "span_multi";
		[JsonInclude]
		[JsonPropertyName("match")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Match { get; set; }
	}

	public sealed partial class SpanMultiTermQueryDescriptor<TDocument> : SerializableDescriptorBase<SpanMultiTermQueryDescriptor<TDocument>>
	{
		internal SpanMultiTermQueryDescriptor(Action<SpanMultiTermQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SpanMultiTermQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer MatchValue { get; set; }

		private QueryContainerDescriptor<TDocument> MatchDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> MatchDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		public SpanMultiTermQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer match)
		{
			MatchDescriptor = null;
			MatchDescriptorAction = null;
			MatchValue = match;
			return Self;
		}

		public SpanMultiTermQueryDescriptor<TDocument> Match(QueryContainerDescriptor<TDocument> descriptor)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			MatchDescriptor = descriptor;
			return Self;
		}

		public SpanMultiTermQueryDescriptor<TDocument> Match(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			MatchValue = null;
			MatchDescriptor = null;
			MatchDescriptorAction = configure;
			return Self;
		}

		public SpanMultiTermQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanMultiTermQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MatchDescriptor is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchDescriptor, options);
			}
			else if (MatchDescriptorAction is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(MatchDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanMultiTermQueryDescriptor : SerializableDescriptorBase<SpanMultiTermQueryDescriptor>
	{
		internal SpanMultiTermQueryDescriptor(Action<SpanMultiTermQueryDescriptor> configure) => configure.Invoke(this);
		public SpanMultiTermQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer MatchValue { get; set; }

		private QueryContainerDescriptor MatchDescriptor { get; set; }

		private Action<QueryContainerDescriptor> MatchDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		public SpanMultiTermQueryDescriptor Match(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer match)
		{
			MatchDescriptor = null;
			MatchDescriptorAction = null;
			MatchValue = match;
			return Self;
		}

		public SpanMultiTermQueryDescriptor Match(QueryContainerDescriptor descriptor)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			MatchDescriptor = descriptor;
			return Self;
		}

		public SpanMultiTermQueryDescriptor Match(Action<QueryContainerDescriptor> configure)
		{
			MatchValue = null;
			MatchDescriptor = null;
			MatchDescriptorAction = configure;
			return Self;
		}

		public SpanMultiTermQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanMultiTermQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MatchDescriptor is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchDescriptor, options);
			}
			else if (MatchDescriptorAction is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(MatchDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}