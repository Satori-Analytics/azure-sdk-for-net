// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Blueprint.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_BlueprintResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/Blueprint_Get.json
            // this example is just showing the usage of "Blueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            BlueprintResource result = await blueprint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/Blueprint_Get.json
            // this example is just showing the usage of "Blueprints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            BlueprintResource result = await blueprint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/Blueprint_Delete.json
            // this example is just showing the usage of "Blueprints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            ArmOperation<BlueprintResource> lro = await blueprint.DeleteAsync(WaitUntil.Completed);
            BlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/Blueprint_Delete.json
            // this example is just showing the usage of "Blueprints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            ArmOperation<BlueprintResource> lro = await blueprint.DeleteAsync(WaitUntil.Completed);
            BlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/Blueprint_Create.json
            // this example is just showing the usage of "Blueprints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            BlueprintData data = new BlueprintData
            {
                Description = "blueprint contains all artifact kinds {'template', 'rbac', 'policy'}",
                TargetScope = BlueprintTargetScope.Subscription,
                Parameters =
{
["costCenter"] = new ParameterDefinition(TemplateParameterType.String)
{
DisplayName = "force cost center tag for all resources under given subscription.",
},
["owners"] = new ParameterDefinition(TemplateParameterType.Array)
{
DisplayName = "assign owners to subscription along with blueprint assignment.",
},
["storageAccountType"] = new ParameterDefinition(TemplateParameterType.String)
{
DisplayName = "storage account type.",
}
},
                ResourceGroups =
{
["storageRG"] = new ResourceGroupDefinition
{
DisplayName = "storage resource group",
Description = "Contains storageAccounts that collect all shoebox logs.",
}
},
            };
            ArmOperation<BlueprintResource> lro = await blueprint.UpdateAsync(WaitUntil.Completed, data);
            BlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ResourceGroupWithTags()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/ResourceGroupWithTags.json
            // this example is just showing the usage of "Blueprints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/{ManagementGroupId}";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            BlueprintData data = new BlueprintData
            {
                Description = "An example blueprint containing an RG with two tags.",
                TargetScope = BlueprintTargetScope.Subscription,
                ResourceGroups =
{
["myRGName"] = new ResourceGroupDefinition
{
Name = "myRGName",
Location = new AzureLocation("westus"),
Tags =
{
["costcenter"] = "123456",
["nameOnlyTag"] = ""
},
DisplayName = "My Resource Group",
}
},
            };
            ArmOperation<BlueprintResource> lro = await blueprint.UpdateAsync(WaitUntil.Completed, data);
            BlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/Blueprint_Create.json
            // this example is just showing the usage of "Blueprints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation
            BlueprintData data = new BlueprintData
            {
                Description = "blueprint contains all artifact kinds {'template', 'rbac', 'policy'}",
                TargetScope = BlueprintTargetScope.Subscription,
                Parameters =
{
["costCenter"] = new ParameterDefinition(TemplateParameterType.String)
{
DisplayName = "force cost center tag for all resources under given subscription.",
},
["owners"] = new ParameterDefinition(TemplateParameterType.Array)
{
DisplayName = "assign owners to subscription along with blueprint assignment.",
},
["storageAccountType"] = new ParameterDefinition(TemplateParameterType.String)
{
DisplayName = "storage account type.",
}
},
                ResourceGroups =
{
["storageRG"] = new ResourceGroupDefinition
{
DisplayName = "storage resource group",
Description = "Contains storageAccounts that collect all shoebox logs.",
}
},
            };
            ArmOperation<BlueprintResource> lro = await blueprint.UpdateAsync(WaitUntil.Completed, data);
            BlueprintResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BlueprintData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPublishedBlueprints_PublishedManagementGroupBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedBlueprint_List.json
            // this example is just showing the usage of "PublishedBlueprints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation and iterate over the result
            await foreach (PublishedBlueprintResource item in blueprint.GetPublishedBlueprintsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublishedBlueprintData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPublishedBlueprints_PublishedSubscriptionBlueprint()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedBlueprint_List.json
            // this example is just showing the usage of "PublishedBlueprints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BlueprintResource created on azure
            // for more information of creating BlueprintResource, please refer to the document of BlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            ResourceIdentifier blueprintResourceId = BlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName);
            BlueprintResource blueprint = client.GetBlueprintResource(blueprintResourceId);

            // invoke the operation and iterate over the result
            await foreach (PublishedBlueprintResource item in blueprint.GetPublishedBlueprintsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PublishedBlueprintData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
