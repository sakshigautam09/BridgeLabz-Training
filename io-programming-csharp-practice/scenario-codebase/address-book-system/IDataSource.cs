using System.Collections.Generic;
using System.Threading.Tasks;

public interface IDataSource
{
    Task SaveAsync(List<Contact> contacts, string bookName);
    Task<List<Contact>> LoadAsync(string bookName);
}
