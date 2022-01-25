using KonusarakOgren.Models.Responses;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Interfaces
{
    public interface IWiredApiProxy
    {
        Task<WiredApiResponse> GetWiredArticles();
    }
}
