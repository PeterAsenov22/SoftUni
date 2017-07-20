using System.Text;

public class Seat:ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Start()
    {
        return "Engine Started!";
    }

    public string Stop()
    {
        return "Breaakk!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}
