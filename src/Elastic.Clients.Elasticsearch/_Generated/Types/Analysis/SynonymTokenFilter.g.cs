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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class SynonymTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("expand")]
		public bool? Expand { get; init; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? Format { get; init; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms")]
		public IReadOnlyCollection<string>? Synonyms { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms_path")]
		public string? SynonymsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public string? Tokenizer { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "synonym";
		[JsonInclude]
		[JsonPropertyName("updateable")]
		public bool? Updateable { get; init; }
	}
}