namespace WMS.Application.DTO;

public record LocationDto(
    int LocationId,
    string LocationCode,
    string LocationName,
    int Capacity,
    int ZoneId,
    string ZoneName,
    string PointX,
    string PointY,
    string PointZ,
    bool IsActive,
    string CreatedAt,
    string UpdatedAt
);