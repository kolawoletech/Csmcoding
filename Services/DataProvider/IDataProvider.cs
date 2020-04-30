using System.Threading.Tasks;
using sm_coding_challenge.Models;

namespace sm_coding_challenge.Services.DataProvider
{
    public interface IDataProvider
    {
        //PlayerModel GetPlayerById(string id);
        Task<PlayerModel> GetPlayerById(string id);
    }
}
