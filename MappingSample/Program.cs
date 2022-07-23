
using MappingSample;


// Map 10.31.0.1 (worker) to site A function1.
Trigger trigger01 = new Trigger { SiteName = "siteA", FunctionName = "function1" };
MappingUtils.WorkerTriggerMapping.AddOrUpdate("10.31.0.1", trigger01,
            (workerName, trigger) => trigger01);
// Map 10.31.0.2 (worker) to site A function2.
Trigger trigger02 = new Trigger { SiteName = "siteA", FunctionName = "function2" };
MappingUtils.WorkerTriggerMapping.AddOrUpdate("10.31.0.2", trigger02,
    (workerName, trigger) => trigger02);
// Dump the result. 
foreach(var kv in MappingUtils.WorkerTriggerMapping)
{
    Console.WriteLine($"[{kv.Key}] : SiteName: {kv.Value.SiteName}, FunctionName: {kv.Value.FunctionName}");
}

