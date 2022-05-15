using Bilfabrik.Models;
using System.Threading.Tasks;

namespace Bilfabrik.Services
{
    public interface IMontörService
    {


        Montör GetMontörbyId(int id);


        bool DeleteMontör(int id);

        bool UpdateMontör(int id, Montör user);



    }
}
