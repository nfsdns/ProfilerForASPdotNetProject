//namespace MyNewProject.Web
//{
//    public class BackgroundJobProcessor
//    {
//    }
//}

using Elastic.Apm;
using Elastic.Apm.Api;
using System;


namespace MyNewProject.Web;

public class BackgroundJobProcessor
{
    public void ProcessJob()
    {
        // Start a transaction
        var transaction = Agent.Tracer.StartTransaction("ProcessJob", "BackgroundJob");

        try
        {
            // Your job processing logic here
            // ...

            // Mark the transaction as successful
            transaction.Result = "Success";
        }
        catch (Exception ex)
        {
            // Capture the exception
            transaction.CaptureException(ex);

            // Mark the transaction as failed
            transaction.Result = "Failure";

            throw;
        }
        finally
        {
            // End the transaction
            transaction.End();
        }
    }
}
