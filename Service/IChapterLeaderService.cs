using ProyectoBCP_API.Models;
using ProyectoBCP_API.Models.Request;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProyectoBCP_API.Service
{
    public interface IChapterLeaderService
    {
        Task<ChapterLeaderRequest> GetChapterLeader(PaginadoRequest PaginadoResponse);
        Task<List<ChapterLeader>> GetAllChapterLeader();
        Task<ChapterLeader> GetChapterById(int id);
        Task<ChapterLeader> InsertChapterLeader(ChapterLeader chapter);
        Task<ChapterLeader> UpdateChapterLeader(int id, ChapterLeader chapter);
        Task<ChapterLeader> DeleteAsyncByid(int id, ChapterLeader chapter);
        Task<ChapterLeader> DeleteAsync(int id);

    }
}
