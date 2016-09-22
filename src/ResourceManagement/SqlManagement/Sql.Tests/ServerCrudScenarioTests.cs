﻿using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Management.Sql;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Sql.Tests
{
    public class ServerCrudScenarioTests
    {
        [Fact]
        public void TestCreateUpdateGetDropServer()
        {
            string testPrefix = "sqlcrudtest-";
            string suiteName = this.GetType().FullName;
            SqlManagementTestUtilities.RunTestInNewResourceGroup(suiteName, "TestCreateUpdateGetDropServer", testPrefix, (resClient, sqlClient, resourceGroup) =>
            {
                string serverNameV12 = SqlManagementTestUtilities.GenerateName(testPrefix);
                string login = "dummylogin";
                string password = "Un53cuRE!";
                string version12 = "12.0";
                Dictionary<string, string> tags = new Dictionary<string, string>()
                    {
                        { "tagKey1", "TagValue1" }
                    };

                var v12Server = sqlClient.Servers.CreateOrUpdate(resourceGroup.Name, serverNameV12, new Microsoft.Azure.Management.Sql.Models.Server()
                {
                    AdministratorLogin = login,
                    AdministratorLoginPassword = password,
                    Version = version12,
                    Tags = tags,
                    Location = SqlManagementTestUtilities.DefaultLocation,
                });
                SqlManagementTestUtilities.ValidateServer(v12Server, serverNameV12, login, version12, tags, SqlManagementTestUtilities.DefaultLocation);

                string serverNameV2 = SqlManagementTestUtilities.GenerateName(testPrefix);
                string version2 = "2.0";
                var v2Server = sqlClient.Servers.CreateOrUpdate(resourceGroup.Name, serverNameV2, new Microsoft.Azure.Management.Sql.Models.Server()
                {
                    AdministratorLogin = login,
                    AdministratorLoginPassword = password,
                    Version = version2,
                    Tags = tags,
                    Location = SqlManagementTestUtilities.DefaultLocation,
                });
                SqlManagementTestUtilities.ValidateServer(v2Server, serverNameV2, login, version2, tags, SqlManagementTestUtilities.DefaultLocation);

                var getV12Server = sqlClient.Servers.Get(resourceGroup.Name, serverNameV12);
                SqlManagementTestUtilities.ValidateServer(getV12Server, serverNameV12, login, version12, tags, SqlManagementTestUtilities.DefaultLocation);

                var getV2Server = sqlClient.Servers.Get(resourceGroup.Name, serverNameV2);
                SqlManagementTestUtilities.ValidateServer(getV2Server, serverNameV2, login, version2, tags, SqlManagementTestUtilities.DefaultLocation);

                var listServers = sqlClient.Servers.List(resourceGroup.Name);
                Assert.Equal(2, listServers.Count());

                sqlClient.Servers.Delete(resourceGroup.Name, serverNameV12);

                var listServers2 = sqlClient.Servers.List(resourceGroup.Name);
                Assert.Equal(1, listServers2.Count());
            });
        }
    }
}
