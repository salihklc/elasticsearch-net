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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class BucketSelectorAggregationConverter : JsonConverter<BucketSelectorAggregation>
	{
		public override BucketSelectorAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			return new BucketSelectorAggregation("");
		}

		public override void Write(Utf8JsonWriter writer, BucketSelectorAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("bucket_selector");
			writer.WriteStartObject();
			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			if (value.BucketsPath is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, value.BucketsPath, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.GapPolicy is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, value.GapPolicy, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(BucketSelectorAggregationConverter))]
	public partial class BucketSelectorAggregation : Aggregations.PipelineAggregationBase
	{
		public BucketSelectorAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
	}

	public sealed partial class BucketSelectorAggregationDescriptor : DescriptorBase<BucketSelectorAggregationDescriptor>
	{
		public BucketSelectorAggregationDescriptor()
		{
		}

		internal BucketSelectorAggregationDescriptor(Action<BucketSelectorAggregationDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		public BucketSelectorAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public BucketSelectorAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath) => Assign(bucketsPath, (a, v) => a.BucketsPathValue = v);
		public BucketSelectorAggregationDescriptor Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public BucketSelectorAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy) => Assign(gapPolicy, (a, v) => a.GapPolicyValue = v);
		public BucketSelectorAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("bucket_selector");
			writer.WriteStartObject();
			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}