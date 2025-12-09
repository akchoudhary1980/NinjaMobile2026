using Microsoft.AspNetCore.Components;
#nullable disable
namespace Ninja.Components.Shared.Utility
{
    public partial class VegNumericField
    {
        [Parameter]
        public double Value { get; set; } = 0;
        [Parameter]
        public double Step { get; set; } = 1;
        [Parameter]
        public double Min { get; set; } = 0;
        [Parameter]
        public double Max { get; set; } = 100;

        [Parameter]
        public EventCallback<double> ValueChanged { get; set; }


        

        private void OnValueChanged(ChangeEventArgs e)
        {
            if (double.TryParse(e.Value?.ToString(), out double newValue))
            {
                Value = newValue;
                ValueChanged.InvokeAsync(Value);
            }
        }


        private void Increment()
        {
            if (Value < Max)
            {
                Value = Value + Step;
                ValueChanged.InvokeAsync(Value);
            }
                
        }

        private void Decrement()
        {
            if (Value > Min)
            {
                Value = Value - Step;
                ValueChanged.InvokeAsync(Value);
            }
        }
    }
}
