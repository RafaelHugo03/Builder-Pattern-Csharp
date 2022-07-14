using BuilderDP.Components;
using BuilderDP.Products;

namespace BuilderDP.Builders
{
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();

        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(EVehicleTransmission transmission);
        void SetVehicleType(EVehicleTyple vehicleType);
    }

}
