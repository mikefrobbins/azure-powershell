### Example 1: Get runtime view of a standby virtual machine pool
```powershell
Get-AzStandbyVMPoolStatus `
-SubscriptionId f8da6e30-a9d8-48ab-b05c-3f7fe482e13b `
-ResourceGroupName test-standbypool `
-Name testPool
```

```output
ForecastValueInstancesRequestedCount :
Id                           : /subscriptions/f8da6e30-a9d8-48ab-b05c-3f7fe482e13b/resourceGroups/test-standbypool/providers/Microsoft.Standb
                               yPool/standbyVirtualMachinePools/testPool/runtimeViews/latest
InstanceCountSummary         : {{
                                "instanceCountsByState": [  
                                    {
                                      "state": "Creating",
                                      "count": 0
                                    },
                                    {
                                      "state": "Starting",
                                      "count": 0
                                    },
                                    {
                                      "state": "Running",
                                      "count": 2
                                    },
                                    {
                                      "state": "Deallocating",
                                      "count": 0
                                    },
                                    {
                                      "state": "Deallocated",
                                      "count": 0
                                    },
                                    {
                                      "state": "Hibernating",
                                      "count": 0
                                    },
                                    {
                                      "state": "Hibernated",
                                      "count": 0
                                    },
                                    {
                                      "state": "Deleting",
                                      "count": 0
                                    }
                                  ]
                                }}
Name                         : latest
PredictionForecastInfo       :
PredictionForecastStartTime  :
ProvisioningState            : Succeeded
ResourceGroupName            : test-standbypool
StatusCode                   : HealthState/healthy
StatusMessage                :
SystemDataCreatedAt          :
SystemDataCreatedBy          :
SystemDataCreatedByType      :
SystemDataLastModifiedAt     :
SystemDataLastModifiedBy     :
SystemDataLastModifiedByType :
Type                         : Microsoft.StandbyPool/standbyVirtualMachinePools/runtimeViews
```

Above command is getting a runtime veiw of standby virtual machine pool.
