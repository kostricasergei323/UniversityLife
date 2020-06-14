using DAL.Entities;
using DAL.Repositories.Interfaces;
using DAL.EF;

namespace DAL.Repositories.Impl
{
    public class EduInfoSystemRepository
        : BaseRepository<EduInfoSystem>, IEduInfoSystemRepository
    {
        internal EduInfoSystemRepository(EduInfoSystemContext context)
            : base(context)
        {
        }
    }
}
