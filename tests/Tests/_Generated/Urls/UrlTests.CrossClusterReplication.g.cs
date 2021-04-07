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
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.Threading.Tasks;
using Tests.Domain;
using Tests.Framework.EndpointTests;

namespace Tests.Urls.CrossClusterReplication
{
    public class CrossClusterReplicationFollowUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.PUT("/project/_ccr/follow").Request(c => c.CrossClusterReplication.CreateFollowIndex(new CreateFollowIndexRequest(Nest.IndexName.From<Project>()))).RequestAsync(c => c.CrossClusterReplication.CreateFollowIndexAsync(new CreateFollowIndexRequest(Nest.IndexName.From<Project>())));
        }
    }
}