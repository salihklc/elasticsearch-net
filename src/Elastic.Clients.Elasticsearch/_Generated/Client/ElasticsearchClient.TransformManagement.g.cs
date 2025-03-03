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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public class TransformManagementNamespace : NamespacedClientProxy
	{
		internal TransformManagementNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public TransformDeleteTransformResponse TransformDeleteTransform(TransformDeleteTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformDeleteTransformRequest, TransformDeleteTransformResponse>(request);
		}

		public Task<TransformDeleteTransformResponse> TransformDeleteTransformAsync(TransformDeleteTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformDeleteTransformRequest, TransformDeleteTransformResponse>(request, cancellationToken);
		}

		public TransformDeleteTransformResponse TransformDeleteTransform(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformDeleteTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformDeleteTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformDeleteTransformRequestDescriptor, TransformDeleteTransformResponse>(descriptor);
		}

		public Task<TransformDeleteTransformResponse> TransformDeleteTransformAsync(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformDeleteTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformDeleteTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformDeleteTransformRequestDescriptor, TransformDeleteTransformResponse>(descriptor);
		}

		public TransformGetTransformResponse TransformGetTransform(TransformGetTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformGetTransformRequest, TransformGetTransformResponse>(request);
		}

		public Task<TransformGetTransformResponse> TransformGetTransformAsync(TransformGetTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformGetTransformRequest, TransformGetTransformResponse>(request, cancellationToken);
		}

		public TransformGetTransformResponse TransformGetTransform(Action<TransformGetTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformGetTransformRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformGetTransformRequestDescriptor, TransformGetTransformResponse>(descriptor);
		}

		public Task<TransformGetTransformResponse> TransformGetTransformAsync(Action<TransformGetTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformGetTransformRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformGetTransformRequestDescriptor, TransformGetTransformResponse>(descriptor);
		}

		public TransformGetTransformStatsResponse TransformGetTransformStats(TransformGetTransformStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformGetTransformStatsRequest, TransformGetTransformStatsResponse>(request);
		}

		public Task<TransformGetTransformStatsResponse> TransformGetTransformStatsAsync(TransformGetTransformStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformGetTransformStatsRequest, TransformGetTransformStatsResponse>(request, cancellationToken);
		}

		public TransformGetTransformStatsResponse TransformGetTransformStats(Elastic.Clients.Elasticsearch.Names transform_id, Action<TransformGetTransformStatsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformGetTransformStatsRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformGetTransformStatsRequestDescriptor, TransformGetTransformStatsResponse>(descriptor);
		}

		public Task<TransformGetTransformStatsResponse> TransformGetTransformStatsAsync(Elastic.Clients.Elasticsearch.Names transform_id, Action<TransformGetTransformStatsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformGetTransformStatsRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformGetTransformStatsRequestDescriptor, TransformGetTransformStatsResponse>(descriptor);
		}

		public TransformPreviewTransformResponse<TTransform> TransformPreviewTransform<TTransform>(TransformPreviewTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformPreviewTransformRequest, TransformPreviewTransformResponse<TTransform>>(request);
		}

		public Task<TransformPreviewTransformResponse<TTransform>> TransformPreviewTransformAsync<TTransform>(TransformPreviewTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformPreviewTransformRequest, TransformPreviewTransformResponse<TTransform>>(request, cancellationToken);
		}

		public TransformPreviewTransformResponse<TTransform> TransformPreviewTransform<TTransform>(Action<TransformPreviewTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformPreviewTransformRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformPreviewTransformRequestDescriptor, TransformPreviewTransformResponse<TTransform>>(descriptor);
		}

		public Task<TransformPreviewTransformResponse<TTransform>> TransformPreviewTransformAsync<TTransform>(Action<TransformPreviewTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformPreviewTransformRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformPreviewTransformRequestDescriptor, TransformPreviewTransformResponse<TTransform>>(descriptor);
		}

		public TransformPutTransformResponse TransformPutTransform(TransformPutTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformPutTransformRequest, TransformPutTransformResponse>(request);
		}

		public Task<TransformPutTransformResponse> TransformPutTransformAsync(TransformPutTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformPutTransformRequest, TransformPutTransformResponse>(request, cancellationToken);
		}

		public TransformPutTransformResponse TransformPutTransform(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformPutTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformPutTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformPutTransformRequestDescriptor, TransformPutTransformResponse>(descriptor);
		}

		public Task<TransformPutTransformResponse> TransformPutTransformAsync(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformPutTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformPutTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformPutTransformRequestDescriptor, TransformPutTransformResponse>(descriptor);
		}

		public TransformStartTransformResponse TransformStartTransform(TransformStartTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformStartTransformRequest, TransformStartTransformResponse>(request);
		}

		public Task<TransformStartTransformResponse> TransformStartTransformAsync(TransformStartTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformStartTransformRequest, TransformStartTransformResponse>(request, cancellationToken);
		}

		public TransformStartTransformResponse TransformStartTransform(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformStartTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformStartTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformStartTransformRequestDescriptor, TransformStartTransformResponse>(descriptor);
		}

		public Task<TransformStartTransformResponse> TransformStartTransformAsync(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformStartTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformStartTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformStartTransformRequestDescriptor, TransformStartTransformResponse>(descriptor);
		}

		public TransformStopTransformResponse TransformStopTransform(TransformStopTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformStopTransformRequest, TransformStopTransformResponse>(request);
		}

		public Task<TransformStopTransformResponse> TransformStopTransformAsync(TransformStopTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformStopTransformRequest, TransformStopTransformResponse>(request, cancellationToken);
		}

		public TransformStopTransformResponse TransformStopTransform(Elastic.Clients.Elasticsearch.Name transform_id, Action<TransformStopTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformStopTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformStopTransformRequestDescriptor, TransformStopTransformResponse>(descriptor);
		}

		public Task<TransformStopTransformResponse> TransformStopTransformAsync(Elastic.Clients.Elasticsearch.Name transform_id, Action<TransformStopTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformStopTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformStopTransformRequestDescriptor, TransformStopTransformResponse>(descriptor);
		}

		public TransformUpdateTransformResponse TransformUpdateTransform(TransformUpdateTransformRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformUpdateTransformRequest, TransformUpdateTransformResponse>(request);
		}

		public Task<TransformUpdateTransformResponse> TransformUpdateTransformAsync(TransformUpdateTransformRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformUpdateTransformRequest, TransformUpdateTransformResponse>(request, cancellationToken);
		}

		public TransformUpdateTransformResponse TransformUpdateTransform(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformUpdateTransformRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformUpdateTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformUpdateTransformRequestDescriptor, TransformUpdateTransformResponse>(descriptor);
		}

		public Task<TransformUpdateTransformResponse> TransformUpdateTransformAsync(Elastic.Clients.Elasticsearch.Id transform_id, Action<TransformUpdateTransformRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformUpdateTransformRequestDescriptor(transform_id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformUpdateTransformRequestDescriptor, TransformUpdateTransformResponse>(descriptor);
		}

		public TransformUpgradeTransformsResponse TransformUpgradeTransforms(TransformUpgradeTransformsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<TransformUpgradeTransformsRequest, TransformUpgradeTransformsResponse>(request);
		}

		public Task<TransformUpgradeTransformsResponse> TransformUpgradeTransformsAsync(TransformUpgradeTransformsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<TransformUpgradeTransformsRequest, TransformUpgradeTransformsResponse>(request, cancellationToken);
		}

		public TransformUpgradeTransformsResponse TransformUpgradeTransforms(Action<TransformUpgradeTransformsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new TransformUpgradeTransformsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<TransformUpgradeTransformsRequestDescriptor, TransformUpgradeTransformsResponse>(descriptor);
		}

		public Task<TransformUpgradeTransformsResponse> TransformUpgradeTransformsAsync(Action<TransformUpgradeTransformsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new TransformUpgradeTransformsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<TransformUpgradeTransformsRequestDescriptor, TransformUpgradeTransformsResponse>(descriptor);
		}
	}
}