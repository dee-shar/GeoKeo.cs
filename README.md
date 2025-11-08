# GeoKeo.cs
Web-API for [geokeo.com](https://geokeo.com/) an geocoding api for forward and reverse search

## Example
```cs
using GeoKeoApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new GeoKeo("YOUR_API_KEY");
            string geoCode = await api.ForwardGeocode("Empire State Building");
            Console.WriteLine(geoCode);
        }
    }
}
```
