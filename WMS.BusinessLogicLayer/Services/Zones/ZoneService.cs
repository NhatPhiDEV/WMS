using WMS.BusinessLogic.Dtos.Zones;
using WMS.Domain.Models;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.BusinessLogic.Services.Zones
{
    public class ZoneService(IUnitOfWork unitOfWork) : IZoneService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        private IGenericRepository<Zone> ZoneRepository => _unitOfWork.GetRepository<Zone>();

        public List<ZoneDto> GetZones()
        {
            var result = ZoneRepository.FindBy(
                z => new ZoneDto
                {
                    ZoneId = z.ZoneId,
                    ZoneName = z.ZoneName
                }, z => z.IsActive == true, null);

            return [.. result];
        }
    }
}
