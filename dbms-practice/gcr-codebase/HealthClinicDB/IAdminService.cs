using System;

public interface IAdminService
{
    void AddSpecialty(string specialtyName);
    void UpdateSpecialty(int id, string specialtyName);
    void DeleteSpecialty(int id);
    void ViewSpecialties();

    void TriggerDatabaseBackup();

    void ViewAuditLogs(string user, string tableName, DateTime? from, DateTime? to);
}
