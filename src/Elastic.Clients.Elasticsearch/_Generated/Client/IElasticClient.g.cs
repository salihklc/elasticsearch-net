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

using Elastic.Clients.Elasticsearch.Cluster;
using Elastic.Clients.Elasticsearch.IndexManagement;
using Elastic.Clients.Elasticsearch.Ingest;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial interface IElasticClient
	{
		ClusterNamespace Cluster { get; }

		IndexManagementNamespace IndexManagement { get; }

		IngestNamespace Ingest { get; }

		BulkResponse Bulk<TSource>(BulkRequest<TSource> request);
		Task<BulkResponse> BulkAsync<TSource>(BulkRequest<TSource> request, CancellationToken cancellationToken = default);
		BulkResponse Bulk<TSource>(Action<BulkRequestDescriptor<TSource>> configureRequest = null);
		Task<BulkResponse> BulkAsync<TSource>(Action<BulkRequestDescriptor<TSource>> configureRequest = null, CancellationToken cancellationToken = default);
		ClosePointInTimeResponse ClosePointInTime(ClosePointInTimeRequest request);
		Task<ClosePointInTimeResponse> ClosePointInTimeAsync(ClosePointInTimeRequest request, CancellationToken cancellationToken = default);
		ClosePointInTimeResponse ClosePointInTime(Action<ClosePointInTimeRequestDescriptor> configureRequest = null);
		Task<ClosePointInTimeResponse> ClosePointInTimeAsync(Action<ClosePointInTimeRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
		CountResponse Count(CountRequest request);
		Task<CountResponse> CountAsync(CountRequest request, CancellationToken cancellationToken = default);
		CountResponse Count<T>(Action<CountRequestDescriptor<T>> configureRequest = null);
		Task<CountResponse> CountAsync<T>(Action<CountRequestDescriptor<T>> configureRequest = null, CancellationToken cancellationToken = default);
		CreateResponse Create<TDocument>(CreateRequest<TDocument> request);
		Task<CreateResponse> CreateAsync<TDocument>(CreateRequest<TDocument> request, CancellationToken cancellationToken = default);
		CreateResponse Create<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<CreateRequestDescriptor<TDocument>> configureRequest = null);
		Task<CreateResponse> CreateAsync<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<CreateRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default);
		DeleteByQueryResponse DeleteByQuery(DeleteByQueryRequest request);
		Task<DeleteByQueryResponse> DeleteByQueryAsync(DeleteByQueryRequest request, CancellationToken cancellationToken = default);
		DeleteByQueryResponse DeleteByQuery<T>(Elastic.Clients.Elasticsearch.Indices indices, Action<DeleteByQueryRequestDescriptor<T>> configureRequest = null);
		Task<DeleteByQueryResponse> DeleteByQueryAsync<T>(Elastic.Clients.Elasticsearch.Indices indices, Action<DeleteByQueryRequestDescriptor<T>> configureRequest = null, CancellationToken cancellationToken = default);
		DeleteResponse Delete(DeleteRequest request);
		Task<DeleteResponse> DeleteAsync(DeleteRequest request, CancellationToken cancellationToken = default);
		DeleteResponse Delete(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<DeleteRequestDescriptor> configureRequest = null);
		Task<DeleteResponse> DeleteAsync(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<DeleteRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
		ExistsResponse Exists(ExistsRequest request);
		Task<ExistsResponse> ExistsAsync(ExistsRequest request, CancellationToken cancellationToken = default);
		ExistsResponse Exists<T>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<ExistsRequestDescriptor<T>> configureRequest = null);
		Task<ExistsResponse> ExistsAsync<T>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<ExistsRequestDescriptor<T>> configureRequest = null, CancellationToken cancellationToken = default);
		GetResponse<TDocument> Get<TDocument>(GetRequest request);
		Task<GetResponse<TDocument>> GetAsync<TDocument>(GetRequest request, CancellationToken cancellationToken = default);
		GetResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<GetRequestDescriptor<TDocument>> configureRequest = null);
		Task<GetResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<GetRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default);
		IndexResponse Index<TDocument>(IndexRequest<TDocument> request);
		Task<IndexResponse> IndexAsync<TDocument>(IndexRequest<TDocument> request, CancellationToken cancellationToken = default);
		IndexResponse Index<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Action<IndexRequestDescriptor<TDocument>> configureRequest = null);
		Task<IndexResponse> IndexAsync<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Action<IndexRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default);
		OpenPointInTimeResponse OpenPointInTime(OpenPointInTimeRequest request);
		Task<OpenPointInTimeResponse> OpenPointInTimeAsync(OpenPointInTimeRequest request, CancellationToken cancellationToken = default);
		OpenPointInTimeResponse OpenPointInTime(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenPointInTimeRequestDescriptor> configureRequest = null);
		Task<OpenPointInTimeResponse> OpenPointInTimeAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenPointInTimeRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
		PingResponse Ping(PingRequest request);
		Task<PingResponse> PingAsync(PingRequest request, CancellationToken cancellationToken = default);
		PingResponse Ping(Action<PingRequestDescriptor> configureRequest = null);
		Task<PingResponse> PingAsync(Action<PingRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default);
		SearchResponse<TDocument> Search<TDocument>(SearchRequest request);
		Task<SearchResponse<TDocument>> SearchAsync<TDocument>(SearchRequest request, CancellationToken cancellationToken = default);
		SearchResponse<TDocument> Search<TDocument>(Action<SearchRequestDescriptor<TDocument>> configureRequest = null);
		Task<SearchResponse<TDocument>> SearchAsync<TDocument>(Action<SearchRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default);
		UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(UpdateRequest<TDocument, TPartialDocument> request);
		Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(UpdateRequest<TDocument, TPartialDocument> request, CancellationToken cancellationToken = default);
		UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(TDocument document, TPartialDocument partialDocument, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configureRequest = null);
		Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(TDocument document, TPartialDocument partialDocument, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configureRequest = null, CancellationToken cancellationToken = default);
	}
}