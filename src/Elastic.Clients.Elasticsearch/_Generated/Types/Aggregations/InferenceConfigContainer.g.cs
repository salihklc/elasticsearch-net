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
	public partial class InferenceConfigContainer
	{
		[JsonInclude]
		[JsonPropertyName("classification")]
		public Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? Classification { get; set; }

		[JsonInclude]
		[JsonPropertyName("regression")]
		public Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? Regression { get; set; }
	}

	public sealed partial class InferenceConfigContainerDescriptor<TDocument> : DescriptorBase<InferenceConfigContainerDescriptor<TDocument>>
	{
		internal InferenceConfigContainerDescriptor(Action<InferenceConfigContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public InferenceConfigContainerDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? RegressionValue { get; set; }

		private RegressionInferenceOptionsDescriptor<TDocument> RegressionDescriptor { get; set; }

		private Action<RegressionInferenceOptionsDescriptor<TDocument>> RegressionDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? ClassificationValue { get; set; }

		private ClassificationInferenceOptionsDescriptor ClassificationDescriptor { get; set; }

		private Action<ClassificationInferenceOptionsDescriptor> ClassificationDescriptorAction { get; set; }

		public InferenceConfigContainerDescriptor<TDocument> Regression(Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? regression)
		{
			RegressionDescriptor = null;
			RegressionDescriptorAction = null;
			RegressionValue = regression;
			return Self;
		}

		public InferenceConfigContainerDescriptor<TDocument> Regression(Aggregations.RegressionInferenceOptionsDescriptor<TDocument> descriptor)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			RegressionDescriptor = descriptor;
			return Self;
		}

		public InferenceConfigContainerDescriptor<TDocument> Regression(Action<Aggregations.RegressionInferenceOptionsDescriptor<TDocument>> configure)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			RegressionDescriptorAction = configure;
			return Self;
		}

		public InferenceConfigContainerDescriptor<TDocument> Classification(Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? classification)
		{
			ClassificationDescriptor = null;
			ClassificationDescriptorAction = null;
			ClassificationValue = classification;
			return Self;
		}

		public InferenceConfigContainerDescriptor<TDocument> Classification(Aggregations.ClassificationInferenceOptionsDescriptor descriptor)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			ClassificationDescriptor = descriptor;
			return Self;
		}

		public InferenceConfigContainerDescriptor<TDocument> Classification(Action<Aggregations.ClassificationInferenceOptionsDescriptor> configure)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			ClassificationDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (RegressionDescriptor is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionDescriptor, options);
			}
			else if (RegressionDescriptorAction is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, new Aggregations.RegressionInferenceOptionsDescriptor<TDocument>(RegressionDescriptorAction), options);
			}
			else if (RegressionValue is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionValue, options);
			}

			if (ClassificationDescriptor is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationDescriptor, options);
			}
			else if (ClassificationDescriptorAction is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, new Aggregations.ClassificationInferenceOptionsDescriptor(ClassificationDescriptorAction), options);
			}
			else if (ClassificationValue is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class InferenceConfigContainerDescriptor : DescriptorBase<InferenceConfigContainerDescriptor>
	{
		internal InferenceConfigContainerDescriptor(Action<InferenceConfigContainerDescriptor> configure) => configure.Invoke(this);
		public InferenceConfigContainerDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? RegressionValue { get; set; }

		private RegressionInferenceOptionsDescriptor RegressionDescriptor { get; set; }

		private Action<RegressionInferenceOptionsDescriptor> RegressionDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? ClassificationValue { get; set; }

		private ClassificationInferenceOptionsDescriptor ClassificationDescriptor { get; set; }

		private Action<ClassificationInferenceOptionsDescriptor> ClassificationDescriptorAction { get; set; }

		public InferenceConfigContainerDescriptor Regression(Elastic.Clients.Elasticsearch.Aggregations.RegressionInferenceOptions? regression)
		{
			RegressionDescriptor = null;
			RegressionDescriptorAction = null;
			RegressionValue = regression;
			return Self;
		}

		public InferenceConfigContainerDescriptor Regression(Aggregations.RegressionInferenceOptionsDescriptor descriptor)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			RegressionDescriptor = descriptor;
			return Self;
		}

		public InferenceConfigContainerDescriptor Regression(Action<Aggregations.RegressionInferenceOptionsDescriptor> configure)
		{
			RegressionValue = null;
			RegressionDescriptorAction = null;
			RegressionDescriptorAction = configure;
			return Self;
		}

		public InferenceConfigContainerDescriptor Classification(Elastic.Clients.Elasticsearch.Aggregations.ClassificationInferenceOptions? classification)
		{
			ClassificationDescriptor = null;
			ClassificationDescriptorAction = null;
			ClassificationValue = classification;
			return Self;
		}

		public InferenceConfigContainerDescriptor Classification(Aggregations.ClassificationInferenceOptionsDescriptor descriptor)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			ClassificationDescriptor = descriptor;
			return Self;
		}

		public InferenceConfigContainerDescriptor Classification(Action<Aggregations.ClassificationInferenceOptionsDescriptor> configure)
		{
			ClassificationValue = null;
			ClassificationDescriptorAction = null;
			ClassificationDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (RegressionDescriptor is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionDescriptor, options);
			}
			else if (RegressionDescriptorAction is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, new Aggregations.RegressionInferenceOptionsDescriptor(RegressionDescriptorAction), options);
			}
			else if (RegressionValue is not null)
			{
				writer.WritePropertyName("regression");
				JsonSerializer.Serialize(writer, RegressionValue, options);
			}

			if (ClassificationDescriptor is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationDescriptor, options);
			}
			else if (ClassificationDescriptorAction is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, new Aggregations.ClassificationInferenceOptionsDescriptor(ClassificationDescriptorAction), options);
			}
			else if (ClassificationValue is not null)
			{
				writer.WritePropertyName("classification");
				JsonSerializer.Serialize(writer, ClassificationValue, options);
			}

			writer.WriteEndObject();
		}
	}
}