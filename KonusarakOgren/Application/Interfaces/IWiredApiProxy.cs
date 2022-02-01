using KonusarakOgren.Application.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Interfaces
{
    public interface IWiredApiProxy
    {
        Task<List<Article>> GetWiredArticles();
    }
}
