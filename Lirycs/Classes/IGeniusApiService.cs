
using System.Threading.Tasks;
using Lirycs.Classes;
using Refit;

namespace Lirycs
{
    public interface IGeniusApiService
    {
        [Headers("Authorization: Bearer " + Constants.ApiKey)]
        [Get("/search?q={song}")]
        Task<SearchResponse> GetSearchResponse(string song);

        // Task<dynamic> GetHeaders([Header("X-Bar")] string bar);

    }
}
