using System.Drawing;
using Pastel;

namespace Items;

public class QualityColorMapper
{
    private readonly Dictionary<QualityEnum, Color> _qualityColors;

    public QualityColorMapper()
    {
        _qualityColors = new Dictionary<QualityEnum, Color>
        {
            { QualityEnum.Poor, Color.Gray},
            { QualityEnum.Common, Color.White },
            { QualityEnum.Uncommon, Color.LawnGreen },
            { QualityEnum.Rare, Color.Blue },
            { QualityEnum.Epic, Color.Purple },
            { QualityEnum.Gold, Color.Gold }
        };
    }

    private Color GetColorForQuality(QualityEnum quality)
    {
        return _qualityColors[quality];
    }

    public string ColorizeStringByQuality(string itemType, QualityEnum quality)
    {
        return itemType.Pastel(GetColorForQuality(quality));
    }
}