using Bilfabrik.Models;

namespace Bilfabrik.Services.StämpelService
{
    public interface IStämpelService
    {
        bool AddStämpel(Stämpel stämpel, int userid);

        StämpeltoUser GetStämpel(int userid);

        bool StämpelUt(int userid);
    }
}
