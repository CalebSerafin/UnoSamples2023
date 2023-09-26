using System.Collections.Immutable;

using Uno2023.DataContracts;

namespace Uno2023.Services.Caching;
public interface IWeatherCache {
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
