# Login to Azure
Connect-AzAccount

# Set variables
$resourceGroupName = "example-resource-group"
$location = "East US"
$storageAccountName = "examplestorageaccount"
$accountTier = "Standard"
$accountReplicationType = "LRS"

# Create a new resource group
New-AzResourceGroup -Name $resourceGroupName -Location $location

# Create a new storage account
New-AzStorageAccount -ResourceGroupName $resourceGroupName -Name $storageAccountName -Location $location -SkuName $accountTier -Kind StorageV2 -ReplicationType $accountReplicationType