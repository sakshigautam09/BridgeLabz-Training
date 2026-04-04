using System;

public class UserActions
{
    [AuditTrail("User Login")]
    public void Login()
    {
    }

    [AuditTrail("Upload File")]
    public void UploadFile()
    {
    }

    public void DeleteTempFiles() // Not audited
    {
    }
}
