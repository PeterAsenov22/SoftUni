using System.Text;

public class Tesla : IElectricCar, ICar
{
    public string Model { get; }
    public string Color { get; }
    public int Battery { get; }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Start()
    {
        return "Vruumvruum";
    }

    public string Stop()
    {
        return "..Out of electricity";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}
