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
	internal sealed class HistogramAggregationConverter : JsonConverter<HistogramAggregation>
	{
		public override HistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "histogram")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new HistogramAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("interval"))
					{
						var value = JsonSerializer.Deserialize<double?>(ref reader, options);
						if (value is not null)
						{
							agg.Interval = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("min_doc_count"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.MinDocCount = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<double?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("offset"))
					{
						var value = JsonSerializer.Deserialize<double?>(ref reader, options);
						if (value is not null)
						{
							agg.Offset = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("order"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder?>(ref reader, options);
						if (value is not null)
						{
							agg.Order = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
					{
						var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
						if (value is not null)
						{
							agg.Aggregations = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, HistogramAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("histogram");
			writer.WriteStartObject();
			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.Interval.HasValue)
			{
				writer.WritePropertyName("interval");
				writer.WriteNumberValue(value.Interval.Value);
			}

			if (value.MinDocCount.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(value.MinDocCount.Value);
			}

			if (value.Missing.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(value.Missing.Value);
			}

			if (value.Offset.HasValue)
			{
				writer.WritePropertyName("offset");
				writer.WriteNumberValue(value.Offset.Value);
			}

			if (value.Order is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, value.Order, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(HistogramAggregationConverter))]
	public partial class HistogramAggregation : BucketAggregationBase, TransformManagement.IPivotGroupByContainerVariant
	{
		public HistogramAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string TransformManagement.IPivotGroupByContainerVariant.PivotGroupByContainerVariantName => "histogram";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("interval")]
		public double? Interval { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_doc_count")]
		public int? MinDocCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public double? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public double? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }
	}

	public sealed partial class HistogramAggregationDescriptor<TDocument> : SerializableDescriptorBase<HistogramAggregationDescriptor<TDocument>>
	{
		internal HistogramAggregationDescriptor(Action<HistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public HistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string? FormatValue { get; set; }

		private double? IntervalValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? MinDocCountValue { get; set; }

		private double? MissingValue { get; set; }

		private double? OffsetValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? OrderValue { get; set; }

		private HistogramOrderDescriptor OrderDescriptor { get; set; }

		private Action<HistogramOrderDescriptor> OrderDescriptorAction { get; set; }

		public HistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Interval(double? interval)
		{
			IntervalValue = interval;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> MinDocCount(int? minDocCount)
		{
			MinDocCountValue = minDocCount;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Offset(double? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? order)
		{
			OrderDescriptor = null;
			OrderDescriptorAction = null;
			OrderValue = order;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Order(HistogramOrderDescriptor descriptor)
		{
			OrderValue = null;
			OrderDescriptorAction = null;
			OrderDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor<TDocument> Order(Action<HistogramOrderDescriptor> configure)
		{
			OrderValue = null;
			OrderDescriptor = null;
			OrderDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (IntervalValue.HasValue)
			{
				writer.WritePropertyName("interval");
				writer.WriteNumberValue(IntervalValue.Value);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			if (OffsetValue.HasValue)
			{
				writer.WritePropertyName("offset");
				writer.WriteNumberValue(OffsetValue.Value);
			}

			if (OrderDescriptor is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderDescriptor, options);
			}
			else if (OrderDescriptorAction is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, new HistogramOrderDescriptor(OrderDescriptorAction), options);
			}
			else if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<TDocument>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class HistogramAggregationDescriptor : SerializableDescriptorBase<HistogramAggregationDescriptor>
	{
		internal HistogramAggregationDescriptor(Action<HistogramAggregationDescriptor> configure) => configure.Invoke(this);
		public HistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string? FormatValue { get; set; }

		private double? IntervalValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? MinDocCountValue { get; set; }

		private double? MissingValue { get; set; }

		private double? OffsetValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? OrderValue { get; set; }

		private HistogramOrderDescriptor OrderDescriptor { get; set; }

		private Action<HistogramOrderDescriptor> OrderDescriptorAction { get; set; }

		public HistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public HistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public HistogramAggregationDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public HistogramAggregationDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public HistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public HistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public HistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public HistogramAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public HistogramAggregationDescriptor Interval(double? interval)
		{
			IntervalValue = interval;
			return Self;
		}

		public HistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public HistogramAggregationDescriptor MinDocCount(int? minDocCount)
		{
			MinDocCountValue = minDocCount;
			return Self;
		}

		public HistogramAggregationDescriptor Missing(double? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public HistogramAggregationDescriptor Offset(double? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public HistogramAggregationDescriptor Order(Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? order)
		{
			OrderDescriptor = null;
			OrderDescriptorAction = null;
			OrderValue = order;
			return Self;
		}

		public HistogramAggregationDescriptor Order(HistogramOrderDescriptor descriptor)
		{
			OrderValue = null;
			OrderDescriptorAction = null;
			OrderDescriptor = descriptor;
			return Self;
		}

		public HistogramAggregationDescriptor Order(Action<HistogramOrderDescriptor> configure)
		{
			OrderValue = null;
			OrderDescriptor = null;
			OrderDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (IntervalValue.HasValue)
			{
				writer.WritePropertyName("interval");
				writer.WriteNumberValue(IntervalValue.Value);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			if (OffsetValue.HasValue)
			{
				writer.WritePropertyName("offset");
				writer.WriteNumberValue(OffsetValue.Value);
			}

			if (OrderDescriptor is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderDescriptor, options);
			}
			else if (OrderDescriptorAction is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, new HistogramOrderDescriptor(OrderDescriptorAction), options);
			}
			else if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}