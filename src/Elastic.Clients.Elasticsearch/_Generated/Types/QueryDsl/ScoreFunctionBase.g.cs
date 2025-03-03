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
	public abstract partial class ScoreFunctionBase
	{
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("weight")]
		public double? Weight { get; set; }
	}

	public sealed partial class ScoreFunctionBaseDescriptor<TDocument> : SerializableDescriptorBase<ScoreFunctionBaseDescriptor<TDocument>>
	{
		internal ScoreFunctionBaseDescriptor(Action<ScoreFunctionBaseDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ScoreFunctionBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private double? WeightValue { get; set; }

		public ScoreFunctionBaseDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public ScoreFunctionBaseDescriptor<TDocument> Filter(QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public ScoreFunctionBaseDescriptor<TDocument> Filter(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public ScoreFunctionBaseDescriptor<TDocument> Weight(double? weight)
		{
			WeightValue = weight;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (WeightValue.HasValue)
			{
				writer.WritePropertyName("weight");
				writer.WriteNumberValue(WeightValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class ScoreFunctionBaseDescriptor : SerializableDescriptorBase<ScoreFunctionBaseDescriptor>
	{
		internal ScoreFunctionBaseDescriptor(Action<ScoreFunctionBaseDescriptor> configure) => configure.Invoke(this);
		public ScoreFunctionBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private double? WeightValue { get; set; }

		public ScoreFunctionBaseDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public ScoreFunctionBaseDescriptor Filter(QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public ScoreFunctionBaseDescriptor Filter(Action<QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public ScoreFunctionBaseDescriptor Weight(double? weight)
		{
			WeightValue = weight;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (WeightValue.HasValue)
			{
				writer.WritePropertyName("weight");
				writer.WriteNumberValue(WeightValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}